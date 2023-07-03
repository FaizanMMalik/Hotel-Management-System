using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class FoodMenu : Form
    {
        
        SqlConnection SqlConn = null;
        string strConn = "Integrated Security=SSPI;Persist Security Info = False; User ID = sa; Initial Catalog = Project; Data Source = LAPTOP-6TKD6K97";
        public FoodMenu()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            CLB.Items.Clear();


            if (cbBreakfast.Checked)
            {
                SqlConnection con = new SqlConnection(strConn);
                string query = "select * from Fooditems where Type='Breakfast'";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    CLB.Items.Add(dataReader[1]);
                }
            }
    
        }

        private void cbLunch_CheckedChanged(object sender, EventArgs e)
        {
            CLB.Items.Clear();


            if (cbLunch.Checked)
            {
                SqlConnection con = new SqlConnection(strConn);
                string query = "select * from Fooditems where Type='Lunch'";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    CLB.Items.Add(dataReader[1]);
                }
            }
          
        }

        private void cbDinner_CheckedChanged(object sender, EventArgs e)
        {
            CLB.Items.Clear();


            if (cbDinner.Checked)
            {
                SqlConnection con = new SqlConnection(strConn);
                string query = "select * from Fooditems where Type='Dinner'";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    CLB.Items.Add(dataReader[1]);
                }
            }
          
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            MENU a = new MENU();
            a.Show();
            this.Hide();
        }
        float total = 0;
        private void btnpo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CLB.SelectedItems.Count; i++)
            {
                SqlConnection con = new SqlConnection(strConn);
                string query = "select Name,Price from FoodItems where Name='" + CLB.SelectedItems[i] + "'";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    total = total + int.Parse(dataReader["Price"].ToString());
                    RTB.Text = RTB.Text+dataReader["Name"].ToString() + "\t" + dataReader["Price"].ToString() + "\n";
                    lblbill.Text = total.ToString();
                  
                }
            }
            }
       
        private void btnaddbill_Click(object sender, EventArgs e)
        {
            float bill = float.Parse(lblbill.Text);
            float tbill = 0;
            tbill= tbill + bill;
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string q = "UPDATE Customer set TotalBill='" + tbill + "' where FirstName='"+ txtfname.Text +"'";
            SqlCommand cd = new SqlCommand(q, conn);
            cd.ExecuteNonQuery();
            conn.Close();
        }

        private void btngenbill_Click(object sender, EventArgs e)
        {
            string tb =lbltb.Text;
        
            string b=lblbill.Text;
            string name = txtfname.Text;

            FileStream f = new FileStream("D:\\CustFoodBill.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(f);
            sw.Write(name+"/n");
            sw.Write(RTB.Text);            
            sw.Write(tb + "\t" + b);
            sw.Close();
            f.Close();

        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            Invoice a = new Invoice();
            a.Show();
            this.Hide();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnshowcustomer_Click(object sender, EventArgs e)
        {
            CustomerInfo a = new CustomerInfo();
            a.Show();
            this.Hide();
        }
    }
}
