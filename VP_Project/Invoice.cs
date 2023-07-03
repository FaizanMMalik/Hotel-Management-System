using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodMenu a = new FoodMenu();
            a.Show();
            this.Hide();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("D:\\CustFoodBill.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(f);
            RTB.Text = sr.ReadToEnd();
            sr.Close();
            f.Close();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
    }

