namespace VP_Project
{
    partial class MENU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btncustinfo = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnstaffinfo = new System.Windows.Forms.Button();
            this.linkLabelExit = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.Location = new System.Drawing.Point(181, 88);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(199, 59);
            this.btnReservation.TabIndex = 5;
            this.btnReservation.Text = "Reserevation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.BtnReservation_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.ForeColor = System.Drawing.Color.White;
            this.btnKitchen.Image = ((System.Drawing.Image)(resources.GetObject("btnKitchen.Image")));
            this.btnKitchen.Location = new System.Drawing.Point(181, 190);
            this.btnKitchen.Margin = new System.Windows.Forms.Padding(0);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(199, 59);
            this.btnKitchen.TabIndex = 6;
            this.btnKitchen.Text = "Kitchen";
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btncustinfo
            // 
            this.btncustinfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btncustinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustinfo.ForeColor = System.Drawing.Color.White;
            this.btncustinfo.Image = ((System.Drawing.Image)(resources.GetObject("btncustinfo.Image")));
            this.btncustinfo.Location = new System.Drawing.Point(440, 190);
            this.btncustinfo.Margin = new System.Windows.Forms.Padding(0);
            this.btncustinfo.Name = "btncustinfo";
            this.btncustinfo.Size = new System.Drawing.Size(199, 59);
            this.btncustinfo.TabIndex = 7;
            this.btncustinfo.Text = "Customer Info";
            this.btncustinfo.UseVisualStyleBackColor = false;
            this.btncustinfo.Click += new System.EventHandler(this.btncustinfo_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DarkGray;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(322, 276);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(199, 59);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnstaffinfo
            // 
            this.btnstaffinfo.BackColor = System.Drawing.Color.LightBlue;
            this.btnstaffinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaffinfo.ForeColor = System.Drawing.Color.White;
            this.btnstaffinfo.Image = ((System.Drawing.Image)(resources.GetObject("btnstaffinfo.Image")));
            this.btnstaffinfo.Location = new System.Drawing.Point(440, 88);
            this.btnstaffinfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnstaffinfo.Name = "btnstaffinfo";
            this.btnstaffinfo.Size = new System.Drawing.Size(199, 59);
            this.btnstaffinfo.TabIndex = 9;
            this.btnstaffinfo.Text = "Staff";
            this.btnstaffinfo.UseVisualStyleBackColor = false;
            this.btnstaffinfo.Click += new System.EventHandler(this.btnstaffinfo_Click);
            // 
            // linkLabelExit
            // 
            this.linkLabelExit.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelExit.LinkColor = System.Drawing.Color.Red;
            this.linkLabelExit.Location = new System.Drawing.Point(782, 0);
            this.linkLabelExit.Name = "linkLabelExit";
            this.linkLabelExit.Size = new System.Drawing.Size(17, 23);
            this.linkLabelExit.TabIndex = 10;
            this.linkLabelExit.TabStop = true;
            this.linkLabelExit.Text = "X";
            this.linkLabelExit.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelExit_LinkClicked);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(657, 407);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 41);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.linkLabelExit);
            this.Controls.Add(this.btnstaffinfo);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btncustinfo);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.btnReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MENU";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btncustinfo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnstaffinfo;
        private System.Windows.Forms.LinkLabel linkLabelExit;
        private System.Windows.Forms.Button btnLogout;
    }
}