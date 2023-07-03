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

namespace VP_Project
{
    public partial class FormLogin : Form
    {
        SqlConnection SqlConn = null;
        string strConn = "Integrated Security=SSPI;Persist Security Info = False; User ID = sa; Initial Catalog = Project; Data Source = FAIZAN101";
        public FormLogin()

        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {


        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string name = txtEname.Text;
            string pass = txtEpass.Text;
            SqlConnection con = new SqlConnection(strConn);
            string query = "select * from Employee where Name='" + name + "' and Password='" + pass + "'";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {

                MENU a = new MENU();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password !");
                MessageBox.Show("Please Retry");

            }

        }

        private void TxtEpass_TextChanged(object sender, EventArgs e)
        {
            txtEpass.PasswordChar = '*';
        }

        private void BtnSignIn_Click_1(object sender, EventArgs e)
        {
          
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            string name = txtEname.Text;
            string pass = txtEpass.Text;
            SqlConnection con = new SqlConnection(strConn);
            string query = "select * from Employee where Name='" + name + "' and Password='" + pass + "'";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {

                MENU a = new MENU();
                a.Show();
                this.Hide();
            }
            else
            {
                string message = "Invalid Username or Password!";
                string title = "Login Failed";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Retry)
                {
                    
                    txtEname.Text = "";
                    txtEpass.Text = "";
                }
                else
                {
                    // Do something  
                }

                
            }
        }

        private void txtEpass_TextChanged_1(object sender, EventArgs e)
        {
            txtEpass.PasswordChar = '*';
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
