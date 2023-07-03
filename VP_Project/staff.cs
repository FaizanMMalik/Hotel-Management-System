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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }
        ProjectEntities dbo = new ProjectEntities();
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVE.DataSource = dbo.Employees.ToList();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MENU a = new MENU();
            a.Show();
            this.Hide();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = txtdata.Text;
            Employee s = dbo.Employees.Where(a => a.Name == name).FirstOrDefault();
            DGVE.DataSource = dbo.Employees.Where(a => a.Name == name).ToList();
            dbo.SaveChanges();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = new List<Employee>();
            if (DD.Text == "ID")
            {
                int id = int.Parse(txtdata.Text);
                Employee s = dbo.Employees.Where(a => a.ID == id).FirstOrDefault();
                result = dbo.Employees.Where(a => a.ID == id).ToList();
                DGVE.DataSource = result;
            }



            
            else if (DD.Text == "Name")
            {
                string firstname = txtdata.Text;
                Employee s = dbo.Employees.Where(a => a.Name == firstname).FirstOrDefault();
                result = dbo.Employees.Where(a => a.Name == firstname).ToList();
                DGVE.DataSource = result;

            }


            
            else if (DD.Text == "Type")
            {
                string lastname = txtdata.Text;
                Employee s = dbo.Employees.Where(a => a.Type == lastname).FirstOrDefault();
                result = dbo.Employees.Where(a => a.Type == lastname).ToList();
                DGVE.DataSource = result;

            }
            else if (DD.Text == "Salary")
            {
                string gender = txtdata.Text;
                Employee s = dbo.Employees.Where(a => a.Salary == gender).FirstOrDefault();
                result = dbo.Employees.Where(a => a.Salary == gender).ToList();
                DGVE.DataSource = result;

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = txtdata.Text;
            Employee s = dbo.Employees.Where(a => a.Name == fname).FirstOrDefault();
            dbo.Employees.Remove(s);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void staff_Load(object sender, EventArgs e)
        {

        }
    }
}
