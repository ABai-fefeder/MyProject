using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業_訂單系統
{
    public partial class Form_OrderList : Form
    {
       
        public Form_OrderList()
        {
            InitializeComponent();
        }

        private void Form_OrderList_Load(object sender, EventArgs e)
        {
            GvOrderList();

            cboxSearch.Items.Add("orderId");
            cboxSearch.Items.Add("訂購人姓名");
            cboxSearch.Items.Add("電話");
            cboxSearch.Items.Add("外送地址");
            cboxSearch.SelectedIndex = 0;
        }

        void GvOrderList()
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "select top 100 o.orderId as 訂單編號 ,o.訂購人姓名,o.電話, o.訂購時間,o.外送地址,s.品項 ,s.訂購數量,s.加蛋,s.加菜脯,s.加飯  from orderList as o  join ShopCartDtails as s on o.orderId = s.orderId;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGvOrderList.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void btnShopDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "delete orderList where orderId = @DeleteId;"
                + "delete ShopCartDtails where orderId = @DeleteId;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@DeleteId", lblID.Text);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            txtSearch.Text = "";

            MessageBox.Show(String.Format("刪除成功, {0} 個資料列受到影響", rows));
            GvOrderList();
        }

        private void dataGvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 列: Rows[位置]  欄: Cells[位置]
                string strSelectedID = dataGvOrderList.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelID);

                if (isID)
                {
                    SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                    con.Open();
                    string strSQL = "select top 100 @SearchID as 訂單編號 ,o.訂購人姓名,o.電話, o.訂購時間,o.外送地址,s.品項 ,s.訂購數量,s.加蛋,s.加菜脯,s.加飯  from orderList as o  join ShopCartDtails as s on o.orderId = s.orderId;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelID);
                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        lblID.Text = reader["訂單編號"].ToString();
                    }

                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            GvOrderList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("請填入關鍵字！！");
            }
            else
            {
                string strSeachData = cboxSearch.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                con.Open();
                string sql = "select top 100 o.orderId as 訂單編號 ,o.訂購人姓名,o.電話, o.訂購時間,o.外送地址,s.品項 ,s.訂購數量,s.加蛋,s.加菜脯,s.加飯 from orderList as o join ShopCartDtails as s on o.orderId = s.orderId where o."+ strSeachData + " like @SearchKeyword;";


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

                dataGvOrderList.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("找不到該筆數據");
                }
                txtSearch.Clear();
            }
        }
    }
}
