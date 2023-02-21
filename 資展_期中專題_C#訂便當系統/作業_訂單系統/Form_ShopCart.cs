using System;
using System.Collections;
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
    public partial class Form_ShopCart : Form
    {
        SqlConnectionStringBuilder scsb;

        string PickAddR;
        int ItemAddR;
        int ShopCartTotal;
        int orderListId;

        List<string> cbAddRice = new List<string>();
        List<int> AddRprice = new List<int>();

        public Form_ShopCart()
        {
            InitializeComponent();
        }

        private void Form_ShopCart_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "bandon";
            scsb.IntegratedSecurity = true;
            GlobalData.DbConStr = scsb.ToString();

            lblAcount.Text = String.Format("登入的帳號為: {0}", GlobalData.Acount);

            if (GlobalData.Acount == "")
            {
                MessageBox.Show("請先登入帳號");
                Form_login login = new Form_login();
                login.ShowDialog();
            }

            txtorderName.Text = GlobalData.userName;
            txtorderTel.Text = GlobalData.userTel;
            txtorderAdress.Text = GlobalData.userAddress;

            ShowuserData();

            foreach (ArrayList AddorderLIst in GlobalData.ShopCartList)
            {
                string Item = (string)AddorderLIst[0];
                int Price = (int)AddorderLIst[1];
                int Count = (int)AddorderLIst[2];
                string AddEgg = (string)AddorderLIst[3];
                string AddVa = (string)AddorderLIst[4];
                int orderTotal = (int)AddorderLIst[5];

                string strListBox = string.Format($"{Item} 單價:{Price} 數量: {Count} 個 加蛋: {AddEgg}  加菜脯: {AddVa} 共: {orderTotal} 元");
                listBoxShopCart.Items.Add(strListBox);
            }

            CountShopCart();

            // cbox
            cbAddRice.Add("無");
            cbAddRice.Add("10元");
            cbAddRice.Add("20元");
            cbAddRice.Add("30元");
            cbAddRice.Add("40元");
            cbAddRice.Add("50元");
            cbAddRice.Add("60元");
            cbAddRice.Add("70元");
            cbAddRice.Add("80元");
            cbAddRice.Add("90元");
            cbAddRice.Add("100元");

            AddRprice.Add(0);
            AddRprice.Add(10);
            AddRprice.Add(20);
            AddRprice.Add(30);
            AddRprice.Add(40);
            AddRprice.Add(50);
            AddRprice.Add(60);
            AddRprice.Add(70);
            AddRprice.Add(80);
            AddRprice.Add(90);
            AddRprice.Add(100);

            foreach (string item in cbAddRice)
            {
                cbboxAddRice.Items.Add(item);
            }

            // 預設
            cbboxAddRice.SelectedIndex = 0;
        }

        void ShowuserData()
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "select * from userData where userId = @userId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@userId", GlobalData.Acount);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                GlobalData.Acount = reader["userId"].ToString();
                txtorderName.Text = reader["姓名"].ToString();
                txtorderTel.Text = reader["電話"].ToString();
                txtorderAdress.Text = reader["地址"].ToString();
            }
            Console.WriteLine("查詢" + i + "筆資料");
            reader.Close();
            con.Close();
        }

        void CountShopCart()
        {
            int delivery = 0;
            foreach (ArrayList AddorderLIst in GlobalData.ShopCartList)
            {
                string Item = (string)AddorderLIst[0];
                int Price = (int)AddorderLIst[1];
                int Count = (int)AddorderLIst[2];
                string AddEgg = (string)AddorderLIst[3];
                string AddVa = (string)AddorderLIst[4];
                int orderTotal = (int)AddorderLIst[5];

                delivery += orderTotal;
            }
            ShopCartTotal = delivery + ItemAddR;
            lblShopCartTotal.Text = String.Format("訂單總價 {0} 元", ShopCartTotal);
        }

        private void cbboxAddRice_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickAddR = cbAddRice[cbboxAddRice.SelectedIndex];
            ItemAddR = AddRprice[cbboxAddRice.SelectedIndex];
            CountShopCart();
        }

        private void txtorderName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtorderTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtorderAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCItem_Click(object sender, EventArgs e)
        {
            if (listBoxShopCart.SelectedIndex > -1)
            {
                int selIndex = listBoxShopCart.SelectedIndex;
                GlobalData.ShopCartList.RemoveAt(selIndex);
                listBoxShopCart.Items.RemoveAt(selIndex);
                CountShopCart();
            }
        }

        private void btnCleanAll_Click(object sender, EventArgs e)
        {
            GlobalData.ShopCartList.Clear();
            listBoxShopCart.Items.Clear();
            cbboxAddRice.SelectedIndex = 0;
            CountShopCart();
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            Random myRandId = new Random();
            orderListId = myRandId.Next(1000, 10000);

            bool telcheck = Regex.IsMatch(txtorderTel.Text, @"^09[0-9]{8}$");

            if (ShopCartTotal >= 150 && (GlobalData.Acount != "") && (txtorderName.Text != "") && telcheck && (txtorderAdress.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                con.Open();
                string strSQL = "insert into ShopCartDtails values(@orderId ,@NewDate ,@NewProducts ,@NewPrice ,@NewCount  ,@NewAddEgg ,@NewAddVa ,@NewAddRice);";

                foreach (ArrayList AddorderLIst in GlobalData.ShopCartList)
                {
                    SqlCommand cmd = new SqlCommand(strSQL, con);


                    string Item = (string)AddorderLIst[0];
                    int Price = (int)AddorderLIst[1];
                    int Count = (int)AddorderLIst[2];
                    string AddEgg = (string)AddorderLIst[3];
                    string AddVa = (string)AddorderLIst[4];
                    int orderTotal = (int)AddorderLIst[5];


                    cmd.Parameters.AddWithValue("@orderId", orderListId);
                    cmd.Parameters.AddWithValue("@NewDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@NewProducts", Item);
                    cmd.Parameters.AddWithValue("@NewPrice", Price);
                    cmd.Parameters.AddWithValue("@NewCount", Count);                   
                    cmd.Parameters.AddWithValue("@NewAddEgg", AddEgg);
                    cmd.Parameters.AddWithValue("@NewAddVa", AddVa);
                    cmd.Parameters.AddWithValue("@NewAddRice", PickAddR);
                    cmd.ExecuteNonQuery();

                    //int rows = cmd.ExecuteNonQuery();
                    //MessageBox.Show("資料儲存成功, 影響orderDtails" + rows + "筆資料");
                }
                con.Close();
                SendorderDtail();
                MessageBox.Show("送出訂單成功");
                listBoxShopCart.Items.Clear();
                GlobalData.ShopCartList.Clear();
                CountShopCart();
                Close();
            }
            else
            {
                if (ShopCartTotal < 150)
                {
                    MessageBox.Show("外送金額需滿150元");
                }
                if (GlobalData.Acount == "")
                {
                    MessageBox.Show("請先登入帳號");
                    Form_login login = new Form_login();
                    login.ShowDialog();
                }
                if (txtorderName.Text == "")
                {
                    MessageBox.Show("請輸入姓名");
                }
                if (txtorderTel.Text == "")
                {
                    MessageBox.Show("請輸入聯絡電話");
                }
                if (txtorderAdress.Text == "")
                {
                    MessageBox.Show("請輸入外送地址");
                }
            }
        }

        void SendorderDtail()
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "insert into orderList values(@orderId ,@NewUserId ,@NewName ,@NewTel ,@NewDate ,@NewAddress ,@NewTotal);";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@orderId", orderListId);
            cmd.Parameters.AddWithValue("@NewUserId", GlobalData.Acount);
            cmd.Parameters.AddWithValue("@NewName", GlobalData.userName);
            cmd.Parameters.AddWithValue("@NewTel", GlobalData.userTel);
            cmd.Parameters.AddWithValue("@NewDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@NewAddress", GlobalData.userAddress);
            cmd.Parameters.AddWithValue("@NewTotal", ShopCartTotal);
            cmd.ExecuteNonQuery();

            //int rows = cmd.ExecuteNonQuery();
            //MessageBox.Show("資料儲存成功, orderList影響" + rows + "筆資料");
            con.Close();
        }
    }
}
