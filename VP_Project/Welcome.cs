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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormLogin a = new FormLogin();
            a.Show();
            this.Hide();
        }

        int startpoint = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 20;
            progressBar1.Value = startpoint;
            lblPercent.Text = startpoint + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                FormLogin a = new FormLogin();
                a.Show();
                this.Hide();
            }
            
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
