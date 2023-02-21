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
    public partial class Form_Products : Form
    {
        List<string> listPname = new List<string>();
        List<int> listPrice = new List<int>();
        List<string> listesc = new List<string>();
        List<int> listId = new List<int>();
        public Form_Products()
        {
            InitializeComponent();
        }

        private void Form_Products_Load(object sender, EventArgs e)
        {

            ShowLiveViewData();
            showListView圖片模式();
        }

        void ShowLiveViewData()
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "select top 100 * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            int i = 0;

            while (reader.Read())
            {
                listId.Add((int)reader["id"]);
                listPname.Add(reader["pname"].ToString());
                listPrice.Add((int)reader["price"]);
                listesc.Add(reader["pdesc"].ToString());
                image_name = reader["pimage"].ToString();
                imageList商品圖檔.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();
        }

        void showListView圖片模式()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon; //LargeIcon, SmallIcon, List, Tile;
            imageList商品圖檔.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageList商品圖檔; //LargeIcon, Tile
            listView商品展示.SmallImageList = imageList商品圖檔; //SmallIcon, List

            for (int i = 0; i < imageList商品圖檔.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listPname[i] + " " + listPrice[i] + "元";
                item.Tag = listId[i];
                listView商品展示.Items.Add(item);
                ;
            }

        }

        void showListView列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("id", 40);
            listView商品展示.Columns.Add("商品名稱", 200);
            listView商品展示.Columns.Add("價格", 80);
            listView商品展示.Columns.Add("商品描述", 500);
            listView商品展示.FullRowSelect = true;
            listView商品展示.GridLines = true;

            for (int i = 0; i < listId.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listId[i].ToString();
                item.SubItems.Add(listPname[i]);
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listesc[i]);
                item.Tag = listId[i];

                listView商品展示.Items.Add(item);
            }
        }

        private void btn圖片模式_Click(object sender, EventArgs e)
        {
            showListView圖片模式();
        }

        private void btn列表模式_Click(object sender, EventArgs e)
        {
            showListView列表模式();
        }

        private void 重新載入_Click(object sender, EventArgs e)
        {
            listId.Clear();
            listPname.Clear();
            listPrice.Clear();
            listesc.Clear();
            imageList商品圖檔.Images.Clear();
            ShowLiveViewData();

            if (listView商品展示.View == View.Details)
            {
                showListView列表模式();
            }
            else
            {
                showListView圖片模式();
            }
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            Form_ProductDtails Open = new Form_ProductDtails();
            Open.ShowDialog();
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            Form_ProductDtails Open = new Form_ProductDtails();
            Open.productID = Convert.ToInt32(listView商品展示.SelectedItems[0].Tag);
            Open.ShowDialog();
        }
    }
}
