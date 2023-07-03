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
    public partial class Reservation : Form
    {
        SqlConnection SqlConn = null;
        string strConn = "Integrated Security=SSPI;Persist Security Info = False; User ID = sa; Initial Catalog = Project; Data Source = LAPTOP-6TKD6K97";
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
           
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            string gender;
            if (rbm.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string query = "INSERT INTO dbo.Customer(CustNo,FirstName,LastName,Gender,Contact,Email,Address,NoOfGuest,RoomType,RoomFloor,AptNo,PaymentType,CardNo) VAlUES('" + txtID.Text + "','" + txtfname.Text + "','" + txtlname.Text + "','" + gender + "','" + txtContact.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + DDnop.Text + "','" + DDrt.Text + "','" + DDrf.Text + "','" + DDan.Text + "','" + DDpt.Text + "','" + txtCardNo.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                
                MessageBox.Show("Customer Added Successfully!");
                
            }
            catch (Exception exp)
            {
                string message = "User already Exists !";
                string title = "Error !";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
              
            }
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            MENU a = new MENU();
            a.Show();
            this.Hide();
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
