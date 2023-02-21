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


namespace 作業_訂單系統
{
    public partial class Form_login : Form
    {
        SqlConnectionStringBuilder scsb;


        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "bandon";
            scsb.IntegratedSecurity = true;
            GlobalData.DbConStr = scsb.ToString();

            txtuserpassword.PasswordChar = '*';

            if (GlobalData.Level == 0)
            {
                btnSignUp.Text = "註冊帳號";
            }
            else if (GlobalData.Level <= 2)
            {
                btnSignUp.Text = "修改會員資料";
            }
            else if (GlobalData.Level >= 2)
            {
                btnSignUp.Visible = false;
            }
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "select * from userData where userId = '" + txtuserId.Text + "' and password ='" + txtuserpassword.Text + "';";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();


            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }

          
            if (count == 1)
            {
                string Acount = txtuserId.Text;
                Acount = string.Format("{0}", txtuserId.Text);
                GlobalData.Acount = Acount;

                MessageBox.Show("登入成功");
                Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤");
            }
            reader.Close();
            con.Close();

            ConUserData();
        }



        void ConUserData()
        {
            SqlConnection con = new SqlConnection(GlobalData.DbConStr);
            con.Open();
            string strSQL = "select * from userData where userId = @SearchId;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchId", GlobalData.Acount);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                // 權限
                GlobalData.Level = Convert.ToInt32(reader["權限"]);

                GlobalData.userName = reader["姓名"].ToString();
                GlobalData.userTel = reader["電話"].ToString();
                GlobalData.userAddress = reader["地址"].ToString();
            }



            reader.Close();
            con.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form_SignUp signUp = new Form_SignUp();
            signUp.ShowDialog();
        }

        private void btnMemEdg_Click(object sender, EventArgs e)
        {
            if (GlobalData.Acount == "")
            {
                MessageBox.Show("請先登入帳號");
            }
            else
            {
                Form_SignUp signUp = new Form_SignUp();
                signUp.ShowDialog();
            }
        }
    }
}
