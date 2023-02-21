using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Reflection.Emit;

namespace 作業_訂單系統
{
    public partial class Form_SignUp : Form
    {
        SqlConnectionStringBuilder scsb;

        string PickMF;
        List<string> cbMF = new List<string>();

        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "bandon";
            scsb.IntegratedSecurity = true;
            GlobalData.DbConStr = scsb.ToString();



            if(GlobalData.Acount == "")
            {
                lblMember.Text = "註冊會員";
                btnSendNewUserData.Enabled = false;
            }
            else
            {
                lblMember.Text = "修改會員資料";
                btnCheckAcount.Visible = false;
                txtUserId.Enabled = false;

                SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                con.Open();
                string strSQL = "select * from userData where userId = @Account;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Account", GlobalData.Acount);
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    string Level = reader["權限"].ToString();
                    txtUserId.Text = reader["userId"].ToString();
                    txtpassword.Text = reader["password"].ToString();
                    txtName.Text = reader["姓名"].ToString();
                    txtPhone.Text = reader["電話"].ToString();
                    txtAdress.Text = reader["地址"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    dptBrithDay.Value = Convert.ToDateTime(reader["生日"]);
                    chkmarriage.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                }
                reader.Close();
                con.Close();
            }



            cbMF.Add("男");
            cbMF.Add("女");

            foreach (string item in cbMF)
            {
                cboxMF.Items.Add(item);
            }
            cboxMF.SelectedIndex = 0;
        }

        private void btnSendNewUserData_Click(object sender, EventArgs e)
        {
            // 資料驗証
            bool telcheck = Regex.IsMatch(txtPhone.Text, @"^09[0-9]{8}$");
            bool EmailCheck = Regex.IsMatch(txtEmail.Text, @"[a-z0-9_\.-]+\@[\da-z\.-]+\.[a-z\.]{2,6}");


            // 註冊
            if (GlobalData.Acount == "")
            {
                if ((txtUserId.Text != "") && (txtpassword.Text != "") && (txtName.Text != "") && telcheck && (txtAdress.Text != "") && EmailCheck)
                {
                    SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                    con.Open();
                    string strSQL = "insert into userData values (@權限 ,@NewUserId, @Newpassword, @NewName, @NewSex, @NewMarriage, @NewPhone, @NewAddress, @NewEmail, @NewBirthDay);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@權限", 1);
                    cmd.Parameters.AddWithValue("@NewUserId", txtUserId.Text);
                    cmd.Parameters.AddWithValue("@Newpassword", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                    cmd.Parameters.AddWithValue("@NewSex", PickMF);
                    cmd.Parameters.AddWithValue("@NewMarriage", chkmarriage.Checked);
                    cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@NewAddress", txtAdress.Text);
                    cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NewBirthDay", dptBrithDay.Value);
                    cmd.ExecuteNonQuery();
                    //int rows = cmd.ExecuteNonQuery();              
                    //MessageBox.Show(String.Format("新增成功, {0} 個資料列受到影響", rows));

                    con.Close();
                    Close();
                    MessageBox.Show("註冊成功");
                }
                else
                {
                    if(txtUserId.Text == "")
                    {
                        MessageBox.Show("請輸入帳號");
                    }
                    else if(txtpassword.Text == "")
                    {
                        MessageBox.Show("請輸入密碼");
                    }
                    else if (txtName.Text == "")
                    {
                        MessageBox.Show("請輸入姓名");
                    }
                    else if (txtAdress.Text == "")
                    {
                        MessageBox.Show("請輸入地址");
                    }
                    else if (txtPhone.Text == "")
                    {
                        MessageBox.Show("請輸入電話");
                    }
                    else if (txtEmail.Text == "")
                    {
                        MessageBox.Show("請輸入Email");
                    }

                    if (telcheck == false)
                    {
                        MessageBox.Show("請輸入10碼行動電話號碼");
                    }
                  
                    if (EmailCheck == false)
                    {
                        MessageBox.Show("請輸入正確Email資料");
                    }
                }
                
            }
            else
            {
                // 修改
                if ((txtpassword.Text != "") && (txtName.Text != "") && telcheck && EmailCheck && (txtAdress.Text != ""))
                {
                    SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                    con.Open();
                    string strSQL = "update userData set userId=@NewuserId, password=@NewPassword, 姓名=@Newname, 性別=@NewSex, 婚姻狀態=@NewMarriage, 電話=@NewPhone, 地址=@NewAddress, Email=@NewEmail, 生日=@NewBirthday where userId=@NewuserId;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Level", GlobalData.Level);
                    cmd.Parameters.AddWithValue("@NewuserId", txtUserId.Text);
                    cmd.Parameters.AddWithValue("@NewPassword", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@Newname", txtName.Text);
                    cmd.Parameters.AddWithValue("@NewSex", PickMF);
                    cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@NewAddress", txtAdress.Text);
                    cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NewBirthday", dptBrithDay.Value);
                    cmd.Parameters.AddWithValue("@NewMarriage", chkmarriage.Checked);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("修改成功");
                    Close();
                }
                else
                {
                    if (txtUserId.Text == "")
                    {
                        MessageBox.Show("請輸入帳號");
                    }
                    else if (txtpassword.Text == "")
                    {
                        MessageBox.Show("請輸入密碼");
                    }
                    else if (txtName.Text == "")
                    {
                        MessageBox.Show("請輸入姓名");
                    }
                    else if (txtAdress.Text == "")
                    {
                        MessageBox.Show("請輸入地址");
                    }
                    else if (txtPhone.Text == "")
                    {
                        MessageBox.Show("請輸入電話");
                    }
                    else if (txtEmail.Text == "")
                    {
                        MessageBox.Show("請輸入Email");
                    }

                    if (telcheck == false)
                    {
                        MessageBox.Show("請輸入10碼行動電話號碼");
                    }

                    if (EmailCheck == false)
                    {
                        MessageBox.Show("請輸入正確Email資料");
                    }
                }
            }           
        }

        private void cboxMF_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickMF = cbMF[cboxMF.SelectedIndex];
        }

        private void btnCheckAcount_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "select * from userData where userId = '" + txtUserId.Text + "';";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();


            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }


            if (count == 1)
            {
                MessageBox.Show("帳號已重複!!!");
            }
            if(count == 0 && txtUserId.Text != "")
            {
                btnSendNewUserData.Enabled = true;
                MessageBox.Show("帳號可以使用");
            }
            else
            {
                if(txtUserId.Text == "")
                {
                    MessageBox.Show("請輸入帳號");
                }
            }
            reader.Close();
            con.Close();
        }
    }
}
