using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業_訂單系統
{
    public partial class Form_Member : Form
    {
        string PickMF;
        int Level = 0;
        List<string> cbMF = new List<string>();

        public Form_Member()
        {
            InitializeComponent();
        }

        private void Form_Member_Load(object sender, EventArgs e)
        {
            GvMemberList();

            cbMF.Add("男");
            cbMF.Add("女");

            foreach (string item in cbMF)
            {
                cboxMF.Items.Add(item);
            }
            cboxMF.SelectedIndex = 0;

            cboxSearch.Items.Add("userId");
            cboxSearch.Items.Add("姓名");
            cboxSearch.Items.Add("電話");
            cboxSearch.Items.Add("Email");
            cboxSearch.Items.Add("地址");
            cboxSearch.SelectedIndex = 0;
        }
        void GvMemberList()
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "select top 100 * from userData;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGvMember.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dataGvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 列: Rows[位置]  欄: Cells[位置]
                string strSelectedID = dataGvMember.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelID);

                if (isID)
                {
                    SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                    con.Open();
                    string strSQL = "select * from userData where id = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    
                    if (reader.Read())
                    {
                        lblID.Text = reader["id"].ToString();
                        string Level = reader["權限"].ToString();
                        txtLevel.Text = reader["權限"].ToString();
                        txtUserId.Text = reader["userId"].ToString();
                        txtPassword.Text = reader["password"].ToString();
                        txt姓名.Text = reader["姓名"].ToString();                        
                        txt電話.Text = reader["電話"].ToString();
                        txt地址.Text = reader["地址"].ToString();
                        txtemail.Text = reader["Email"].ToString();
                        dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                        chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);

                        if(Level == "1")
                        {
                            lblLevel.Text = "權限1:會員";
                        }
                        else if(Level == "2")
                        {
                            lblLevel.Text = "權限2:員工";
                        }
                        else if(Level == "3")
                        {
                            lblLevel.Text = "權限3:管理員";
                        }
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        lblID.Text = "";
                        txt姓名.Clear();
                        txt電話.Clear();
                        txt地址.Clear();
                        txtemail.Clear();
                        dtp生日.Value = DateTime.Now;
                        chk婚姻狀態.Checked = false;
                    }

                    reader.Close();
                    con.Close();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool telcheck = Regex.IsMatch(txt電話.Text, @"^09[0-9]{8}$");
            bool EmailCheck = Regex.IsMatch(txtemail.Text, @"[a-z0-9_\.-]+\@[\da-z\.-]+\.[a-z\.]{2,6}");


            if ((txt姓名.Text != "") && (txt電話.Text != ""))
            {
                // 欄位驗証
                SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                con.Open();
                string strSQL = "insert into userData values (@Level, @NewuserId, @NewPassword, @Newname, @NewSex, @NewMarriage, @NewPhone, @NewAddress, @NewEmail, @NewBirthday);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                Int32.TryParse(txtLevel.Text, out Level);
                cmd.Parameters.AddWithValue("@Level", Level);
                cmd.Parameters.AddWithValue("@NewuserId", txtUserId.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Newname", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewSex", PickMF);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtemail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show(String.Format("新增成功, {0} 個資料列受到影響", rows));               
            }
            GvMemberList();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // 欄位驗証
            bool telcheck = Regex.IsMatch(txt電話.Text, @"^09[0-9]{8}$");
            bool EmailCheck = Regex.IsMatch(txtemail.Text, @"[a-z0-9_\.-]+\@[\da-z\.-]+\.[a-z\.]{2,6}");

            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txt姓名.Text != "") && telcheck && EmailCheck && (txtLevel.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                con.Open();
                string strSQL = "update userData set 權限=@Level, userId=@NewuserId, password=@NewPassword, 姓名=@Newname, 性別=@NewSex, 婚姻狀態=@NewMarriage, 電話=@NewPhone, 地址=@NewAddress, Email=@NewEmail, 生日=@NewBirthday where id =@SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                Int32.TryParse(txtLevel.Text, out Level);
                cmd.Parameters.AddWithValue("@Level", Level);
                cmd.Parameters.AddWithValue("@NewuserId", txtUserId.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Newname", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewSex", PickMF);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtemail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                cmd.Parameters.AddWithValue("@SearchId", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(String.Format("異動成功, {0} 個資料列受到影響", rows));
                清空欄位();               
            }
            GvMemberList();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        void 清空欄位()
        {
            lblID.Text = "";
            lblLevel.Text = "權限";
            txtLevel.Clear();
            txtUserId.Clear();
            txtPassword.Clear();
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txtemail.Clear();
            dtp生日.Value = DateTime.Now;
            chk婚姻狀態.Checked = false;
        }

        private void cboxMF_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickMF = cbMF[cboxMF.SelectedIndex];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (txtSearch.Text != "")
            //{
            //    string strSeachData = cboxSearch.SelectedItem.ToString();

            //    SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            //    con.Open();
            //    string strSQL = "select * from userData where " + strSeachData + " like @SearchKeyword;";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@SearchKeyword","%" + txtSearch.Text + "%");
            //    SqlDataReader reader = cmd.ExecuteReader();

            //    int Count = 0;
            //    while (reader.Read())
            //    {
            //        Count += 1;
            //    }

            //    if (Count == 1 && reader.HasRows)
            //    {
            //        DataTable dt = new DataTable();
            //        dt.Load(reader);
            //        dataGvMember.DataSource = dt;
            //    }

            //    if (Count == 0)
            //    {
            //        MessageBox.Show("查無資料");
            //        txtSearch.Clear();
            //    }

            //    reader.Close();
            //    con.Close();
            //    txtSearch.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("請輸入查詢關鍵字");
            //}

            if (txtSearch.Text == "")
            {
                MessageBox.Show("請填入關鍵字！！");
            }
            else
            {
                string strSeachData = cboxSearch.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                con.Open();
                string sql = "select * from userData where " + strSeachData + " like @SearchKeyword;";

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter p = new SqlParameter();
                p.ParameterName = "@name";
                p.DbType = DbType.String;
                p.Value = txtSearch.Text;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@SearchKeyword", "%" + txtSearch.Text + "%");
                da.Fill(ds);
                con.Close();

                dataGvMember.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("找不到該筆數據");
                }

                txtSearch.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                con.Open();
                string strSQL = "delete from userData where id = @DeleteId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteId", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show(String.Format("刪除成功, {0} 個資料列受到影響", rows));
                GvMemberList();
            }
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            GvMemberList();
        }
    }
}
