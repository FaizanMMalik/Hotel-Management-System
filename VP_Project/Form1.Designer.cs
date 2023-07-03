namespace VP_Project
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtEpass = new System.Windows.Forms.TextBox();
            this.lblEname = new System.Windows.Forms.Label();
            this.lblEpass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnsign = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtEname
            // 
            this.txtEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEname.ForeColor = System.Drawing.Color.Black;
            this.txtEname.Location = new System.Drawing.Point(305, 113);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(181, 31);
            this.txtEname.TabIndex = 0;
            this.txtEname.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtEpass
            // 
            this.txtEpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpass.ForeColor = System.Drawing.Color.Black;
            this.txtEpass.Location = new System.Drawing.Point(305, 212);
            this.txtEpass.Name = "txtEpass";
            this.txtEpass.Size = new System.Drawing.Size(181, 31);
            this.txtEpass.TabIndex = 1;
            this.txtEpass.TextChanged += new System.EventHandler(this.txtEpass_TextChanged_1);
            // 
            // lblEname
            // 
            this.lblEname.AutoSize = true;
            this.lblEname.BackColor = System.Drawing.Color.Transparent;
            this.lblEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEname.ForeColor = System.Drawing.Color.White;
            this.lblEname.Location = new System.Drawing.Point(300, 85);
            this.lblEname.Name = "lblEname";
            this.lblEname.Size = new System.Drawing.Size(118, 25);
            this.lblEname.TabIndex = 2;
            this.lblEname.Text = "Username";
            // 
            // lblEpass
            // 
            this.lblEpass.AutoSize = true;
            this.lblEpass.BackColor = System.Drawing.Color.Transparent;
            this.lblEpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpass.ForeColor = System.Drawing.Color.White;
            this.lblEpass.Location = new System.Drawing.Point(304, 184);
            this.lblEpass.Name = "lblEpass";
            this.lblEpass.Size = new System.Drawing.Size(114, 25);
            this.lblEpass.TabIndex = 3;
            this.lblEpass.Text = "Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(30, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 31);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login";
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsign.Location = new System.Drawing.Point(332, 266);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(126, 53);
            this.btnsign.TabIndex = 6;
            this.btnsign.Text = "Sign In";
            this.btnsign.UseVisualStyleBackColor = false;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(781, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(19, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblEpass);
            this.Controls.Add(this.lblEname);
            this.Controls.Add(this.txtEpass);
            this.Controls.Add(this.txtEname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtEpass;
        private System.Windows.Forms.Label lblEname;
        private System.Windows.Forms.Label lblEpass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

