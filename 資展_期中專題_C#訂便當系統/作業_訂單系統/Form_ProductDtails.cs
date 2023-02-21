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
    public partial class Form_ProductDtails : Form
    {
        public int productID = 0;
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖檔 = false;
        public Form_ProductDtails()
        {
            InitializeComponent();
        }

        private void Form_ProductDtails_Load(object sender, EventArgs e)
        {
            if (productID == 0)
            { 
                groupBox新增商品.Visible = true;
                groupBox修改商品.Visible = false;
            }
            else
            { 
                groupBox新增商品.Visible = false;
                groupBox修改商品.Visible = true;
                ShowProductDtails();
            }
        }

        void ShowProductDtails()
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
                lblID.Text = reader["id"].ToString();
                txt商品名稱.Text = reader["pname"].ToString();
                txt商品價格.Text = reader["price"].ToString();
                txt商品描述.Text = reader["pdesc"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            Console.WriteLine("查詢" + i + "筆資料");
            reader.Close();
            con.Close();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                con.Open();
                string strSQL = "update products set pname=@NewName, price=@NewPrice, pdesc=@NewDesc, pimage=@NewImageName where id = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", productID);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImageName", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料儲存成功, 影響" + rows + "筆資料");
                Close();
            }
            else
            {
                MessageBox.Show("請填入正確資訊!!");
            }
        }

        private void btn選取修改商品照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExt;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txt商品名稱.Clear();
            txt商品描述.Clear();
            txt商品價格.Clear();
            pictureBox商品圖檔.Image = null;
        }

        private void btn選取新增商品照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExt;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(GlobalData.DbConStr);
                con.Open();
                string strSQL = "insert into products values(@NewName, @NewPrice, @NewPdesc, @NewImageName);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPdesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImageName", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料儲存成功, 影響" + rows + "筆資料");
                Close();

            }
            else
            {
                MessageBox.Show("請填入正確資訊!!");
            }
        }

        private void txt商品價格_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txt商品價格.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
