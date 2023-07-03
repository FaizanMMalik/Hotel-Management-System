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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            this.Hide();
        }

        private void BtnReservation_Click(object sender, EventArgs e)
        {
            Reservation a = new Reservation();
            a.Show();
            this.Hide();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            FoodMenu a = new FoodMenu();
            a.Show();
            this.Hide();
        }

        private void btncustinfo_Click(object sender, EventArgs e)
        {
           CustomerInfo a = new CustomerInfo();
            a.Show();
            this.Hide();
        }

        private void btnstaffinfo_Click(object sender, EventArgs e)
        {
            staff a = new staff();
            a.Show();
            this.Hide();
        }

        private void LinkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Close();
        }
    }
}
