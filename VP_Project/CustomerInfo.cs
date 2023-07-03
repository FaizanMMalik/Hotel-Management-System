using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class CustomerInfo : Form
    {
        ProjectEntities dbo = new ProjectEntities();
        public CustomerInfo()
        {
            InitializeComponent();
        }
        
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = new List<Customer>();
            if (DD.Text == "ID")
            {
                int id = int.Parse(txtdata.Text);
                Customer s = dbo.Customers.Where(a => a.CustNo == id).FirstOrDefault();
                result = dbo.Customers.Where(a => a.CustNo == id).ToList();
                DGVC.DataSource = result;
            }



            
            else if (DD.Text == "First Name")
            {
                string firstname = txtdata.Text;
                Customer s = dbo.Customers.Where(a => a.FirstName == firstname).FirstOrDefault();
                result = dbo.Customers.Where(a => a.FirstName == firstname).ToList();
                DGVC.DataSource = result;

            }


            
            else if (DD.Text == "Last Name")
            {
                string lastname = txtdata.Text;
                Customer s = dbo.Customers.Where(a => a.LastName == lastname).FirstOrDefault();
                result = dbo.Customers.Where(a => a.LastName == lastname).ToList();
                DGVC.DataSource = result;

            }
            else if (DD.Text == "Gender")
            {
                string gender = txtdata.Text;
                Customer s = dbo.Customers.Where(a => a.Gender == gender).FirstOrDefault();
                result = dbo.Customers.Where(a => a.Gender == gender).ToList();
                DGVC.DataSource = result;

            }
            else if (DD.Text == "Room Tyoe")
            {
                string roomtype = txtdata.Text;
                Customer s = dbo.Customers.Where(a => a.Gender == roomtype).FirstOrDefault();
                result = dbo.Customers.Where(a => a.Gender == roomtype).ToList();
                DGVC.DataSource = result;

            }
            else if (DD.Text == "Apartment No")
            {
                string apartmentno = txtdata.Text;
                Customer s = dbo.Customers.Where(a => a.Gender == apartmentno).FirstOrDefault();
                result = dbo.Customers.Where(a => a.Gender == apartmentno).ToList();
                DGVC.DataSource = result;

            }
            //else if (result.Count == 0)
            //{
            //    lberr.Text = "Result Not Found !";
            //}
            //else
            //{
            //    lberr.Text = "Please Select a type!";

            //}

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVC.DataSource = dbo.Customers.ToList();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MENU a = new MENU();
            a.Show();
            this.Hide();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string fname = txtdata.Text;
            Customer s = dbo.Customers.Where(a => a.FirstName == fname).FirstOrDefault();
            DGVC.DataSource = dbo.Customers.Where(a => a.FirstName == fname).ToList();
            dbo.SaveChanges();


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = txtdata.Text;
            Customer s = dbo.Customers.Where(a => a.FirstName == fname).FirstOrDefault();
            dbo.Customers.Remove(s);
            dbo.SaveChanges();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
