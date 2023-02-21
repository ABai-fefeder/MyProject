using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace 作業_訂單系統
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        public bool isReLogin = false;

        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form_login login = new Form_login();
            login.ShowDialog();

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; 
            scsb.InitialCatalog = "bandon";
            scsb.IntegratedSecurity = true;
            GlobalData.DbConStr = scsb.ToString();

            showListView列表模式();


            // 預設值
            // 登入
            btnOrderList.Visible = false;
            btnMember.Visible = false;
            btnProducts.Visible = false;

            if (GlobalData.Level == 2)
            {
                btnOrderList.Visible = true;
            }

            if (GlobalData.Level == 3)
            {
                btnOrderList.Visible = true;
                btnMember.Visible = true;
                btnProducts.Visible = true;
            }
        }

        void showListView列表模式()
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "select top 100 * from products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listId.Add((int)reader["id"]);
                listPname.Add(reader["Pname"].ToString());
                listPrice.Add((int)reader["price"]);

            }
            reader.Close();
            con.Close();

            listViewItem.Clear();
            listViewItem.LargeImageList = null;
            listViewItem.SmallImageList = null;
            listViewItem.View = View.Details;
            listViewItem.Columns.Add("", 50);
            listViewItem.Columns.Add("商品名稱", 200);
            listViewItem.Columns.Add("價格", 150);
            listViewItem.FullRowSelect = true;
            listViewItem.GridLines = true;

            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listId[i].ToString();
                item.SubItems.Add(listPname[i]);
                item.SubItems.Add(listPrice[i].ToString());
                item.Tag = listId[i];

                listViewItem.Items.Add(item);
            }
        }
    


        private void listViewItem_ItemActivate(object sender, EventArgs e)
        {
            OrderDtails myformDetail = new OrderDtails();
            myformDetail.productID = Convert.ToInt32(listViewItem.SelectedItems[0].Tag);
            myformDetail.ShowDialog();
            Refresh();
        }

        private void btnShopCart_Click(object sender, EventArgs e)
        {
            Form_ShopCart form訂單品項列表 = new Form_ShopCart();
            form訂單品項列表.ShowDialog();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            Form_login login = new Form_login();
            login.ShowDialog();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            if (GlobalData.Level == 2 || GlobalData.Level == 3)
            {
                Form_OrderList Open = new Form_OrderList();
                Open.ShowDialog();
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            if (GlobalData.Level == 3)
            {
                Form_Member Open = new Form_Member();
                Open.ShowDialog();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (GlobalData.Level == 3)
            {
                Form_Products Open = new Form_Products();
                Open.ShowDialog();
            }
        }
    }
}
