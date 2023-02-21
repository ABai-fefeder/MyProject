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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 作業_訂單系統
{
    public partial class OrderDtails : Form
    {
        SqlConnectionStringBuilder scsb;

        public int productID = 0;
        string orderItem;
        int Total;
        int ItemCount;
        int ItemPrice;

        string PickAddE;
        int AddEPrice;
        string PickVa;

        string image_dir = @"images\";
        string image_name = "";

        List<string> cbAddEgg = new List<string>();
        List<string> cbAddVa = new List<string>();
        List<int> AddEprice = new List<int>();



        public OrderDtails()
        {
            InitializeComponent();
        }

        private void OrderDtails_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "bandon";
            scsb.IntegratedSecurity = true;
            GlobalData.DbConStr = scsb.ToString();

            ShowProducts();

            // cbbox
            cbAddEgg.Add("無");
            cbAddEgg.Add("10元");

            cbAddVa.Add("無");
            cbAddVa.Add("要");

            AddEprice.Add(0);
            AddEprice.Add(10);

            foreach (string item in cbAddEgg)
            {
                cbboxAddEgg.Items.Add(item);
            }
            foreach (string item in cbAddVa)
            {
                cbboxAddVa.Items.Add(item);
            }
            // 預設
            txtCount.Text = "1";
            cbboxAddEgg.SelectedIndex = 0;
            cbboxAddVa.SelectedIndex = 1;
        }

        void ShowProducts()
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "select * from products where id = @SearchId;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchId", productID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                image_name = reader["pimage"].ToString();
                pboxProducts.Image = Image.FromFile(image_dir + image_name);
                lblid.Text = reader["id"].ToString();
                lblProductsName.Text = reader["pname"].ToString();
                lblPrice.Text = reader["Price"].ToString();
                orderItem = reader["pname"].ToString();
                i += 1;
            }
            Console.WriteLine("查詢" + i + "筆資料");
            reader.Close();
            con.Close();
        }
        
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ItemCount = Convert.ToInt32(txtCount.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            } 
            CountTotal();
        }

        void CountTotal()
        {
            Int32.TryParse(lblPrice.Text, out ItemPrice);

            Total = ItemPrice * ItemCount + AddEPrice * ItemCount;
            lblTotal.Text = Total.ToString();
        }


        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if ((txtCount.Text != "0") && (GlobalData.Acount != ""))
            {
                ArrayList AddorderLIst = new ArrayList();
                AddorderLIst.Add(orderItem);
                AddorderLIst.Add(ItemPrice);
                AddorderLIst.Add(ItemCount);
                AddorderLIst.Add(PickAddE);
                AddorderLIst.Add(PickVa);
                AddorderLIst.Add(Total);

                GlobalData.ShopCartList.Add(AddorderLIst);
                MessageBox.Show("已加入到訂購單");

                Close();
            }
            else
            {
                MessageBox.Show("請先登入帳號");
                Form_login login = new Form_login();
                login.ShowDialog();
            }
        }


        private void cbboxAddEgg_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickAddE = cbAddEgg[cbboxAddEgg.SelectedIndex];
            AddEPrice = AddEprice[cbboxAddEgg.SelectedIndex];
            CountTotal();
        }

        private void cbboxAddVa_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickVa = cbAddVa[cbboxAddVa.SelectedIndex];
        }
    }
}
