namespace VP_Project
{
    partial class FoodMenu
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
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.cbDinner = new System.Windows.Forms.CheckBox();
            this.cbLunch = new System.Windows.Forms.CheckBox();
            this.cbBreakfast = new System.Windows.Forms.CheckBox();
            this.CLB = new System.Windows.Forms.CheckedListBox();
            this.btngoback = new System.Windows.Forms.Button();
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.lblorder = new System.Windows.Forms.Label();
            this.btnpo = new System.Windows.Forms.Button();
            this.lbltb = new System.Windows.Forms.Label();
            this.lblbill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.btnaddbill = new System.Windows.Forms.Button();
            this.btngenbill = new System.Windows.Forms.Button();
            this.btninvoice = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnshowcustomer = new System.Windows.Forms.Button();
            this.gbTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTypes
            // 
            this.gbTypes.BackColor = System.Drawing.Color.White;
            this.gbTypes.Controls.Add(this.cbDinner);
            this.gbTypes.Controls.Add(this.cbLunch);
            this.gbTypes.Controls.Add(this.cbBreakfast);
            this.gbTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTypes.Location = new System.Drawing.Point(12, 12);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Size = new System.Drawing.Size(776, 141);
            this.gbTypes.TabIndex = 0;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "TYPES";
            this.gbTypes.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // cbDinner
            // 
            this.cbDinner.AutoSize = true;
            this.cbDinner.Location = new System.Drawing.Point(672, 37);
            this.cbDinner.Name = "cbDinner";
            this.cbDinner.Size = new System.Drawing.Size(85, 28);
            this.cbDinner.TabIndex = 2;
            this.cbDinner.Text = "Dinner";
            this.cbDinner.UseVisualStyleBackColor = true;
            this.cbDinner.CheckedChanged += new System.EventHandler(this.cbDinner_CheckedChanged);
            // 
            // cbLunch
            // 
            this.cbLunch.AutoSize = true;
            this.cbLunch.Location = new System.Drawing.Point(354, 37);
            this.cbLunch.Name = "cbLunch";
            this.cbLunch.Size = new System.Drawing.Size(82, 28);
            this.cbLunch.TabIndex = 1;
            this.cbLunch.Text = "Lunch";
            this.cbLunch.UseVisualStyleBackColor = true;
            this.cbLunch.CheckedChanged += new System.EventHandler(this.cbLunch_CheckedChanged);
            // 
            // cbBreakfast
            // 
            this.cbBreakfast.AutoSize = true;
            this.cbBreakfast.Location = new System.Drawing.Point(6, 37);
            this.cbBreakfast.Name = "cbBreakfast";
            this.cbBreakfast.Size = new System.Drawing.Size(104, 28);
            this.cbBreakfast.TabIndex = 0;
            this.cbBreakfast.Text = "Breakfast";
            this.cbBreakfast.UseVisualStyleBackColor = true;
            this.cbBreakfast.CheckedChanged += new System.EventHandler(this.CbBreakfast_CheckedChanged);
            // 
            // CLB
            // 
            this.CLB.BackColor = System.Drawing.Color.White;
            this.CLB.FormattingEnabled = true;
            this.CLB.Location = new System.Drawing.Point(32, 159);
            this.CLB.Name = "CLB";
            this.CLB.Size = new System.Drawing.Size(416, 184);
            this.CLB.TabIndex = 1;
            this.CLB.SelectedIndexChanged += new System.EventHandler(this.CLB_SelectedIndexChanged);
            // 
            // btngoback
            // 
            this.btngoback.BackColor = System.Drawing.Color.White;
            this.btngoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngoback.Location = new System.Drawing.Point(552, 428);
            this.btngoback.Name = "btngoback";
            this.btngoback.Size = new System.Drawing.Size(191, 53);
            this.btngoback.TabIndex = 35;
            this.btngoback.Text = "Go Back";
            this.btngoback.UseVisualStyleBackColor = false;
            this.btngoback.Click += new System.EventHandler(this.btngoback_Click);
            // 
            // RTB
            // 
            this.RTB.BackColor = System.Drawing.Color.White;
            this.RTB.Location = new System.Drawing.Point(18, 377);
            this.RTB.Name = "RTB";
            this.RTB.Size = new System.Drawing.Size(508, 115);
            this.RTB.TabIndex = 38;
            this.RTB.Text = "";
            // 
            // lblorder
            // 
            this.lblorder.AutoSize = true;
            this.lblorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorder.ForeColor = System.Drawing.Color.Black;
            this.lblorder.Location = new System.Drawing.Point(33, 349);
            this.lblorder.Name = "lblorder";
            this.lblorder.Size = new System.Drawing.Size(127, 25);
            this.lblorder.TabIndex = 37;
            this.lblorder.Text = "Order Detail";
            // 
            // btnpo
            // 
            this.btnpo.BackColor = System.Drawing.Color.White;
            this.btnpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpo.Location = new System.Drawing.Point(532, 377);
            this.btnpo.Name = "btnpo";
            this.btnpo.Size = new System.Drawing.Size(107, 35);
            this.btnpo.TabIndex = 36;
            this.btnpo.Text = "Place Order";
            this.btnpo.UseVisualStyleBackColor = false;
            this.btnpo.Click += new System.EventHandler(this.btnpo_Click);
            // 
            // lbltb
            // 
            this.lbltb.AutoSize = true;
            this.lbltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltb.ForeColor = System.Drawing.Color.Black;
            this.lbltb.Location = new System.Drawing.Point(547, 320);
            this.lbltb.Name = "lbltb";
            this.lbltb.Size = new System.Drawing.Size(107, 25);
            this.lbltb.TabIndex = 40;
            this.lbltb.Text = "Total Bill :";
            // 
            // lblbill
            // 
            this.lblbill.AutoSize = true;
            this.lblbill.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbill.Location = new System.Drawing.Point(712, 320);
            this.lblbill.Name = "lblbill";
            this.lblbill.Size = new System.Drawing.Size(0, 25);
            this.lblbill.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(456, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Customer Name";
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.ForeColor = System.Drawing.Color.Black;
            this.txtfname.Location = new System.Drawing.Point(607, 170);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(181, 31);
            this.txtfname.TabIndex = 41;
            // 
            // btnaddbill
            // 
            this.btnaddbill.BackColor = System.Drawing.Color.White;
            this.btnaddbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbill.Location = new System.Drawing.Point(633, 227);
            this.btnaddbill.Name = "btnaddbill";
            this.btnaddbill.Size = new System.Drawing.Size(136, 35);
            this.btnaddbill.TabIndex = 43;
            this.btnaddbill.Text = "Add Bill";
            this.btnaddbill.UseVisualStyleBackColor = false;
            this.btnaddbill.Click += new System.EventHandler(this.btnaddbill_Click);
            // 
            // btngenbill
            // 
            this.btngenbill.BackColor = System.Drawing.Color.White;
            this.btngenbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenbill.Location = new System.Drawing.Point(633, 268);
            this.btngenbill.Name = "btngenbill";
            this.btngenbill.Size = new System.Drawing.Size(136, 35);
            this.btngenbill.TabIndex = 44;
            this.btngenbill.Text = "Generate Bill";
            this.btngenbill.UseVisualStyleBackColor = false;
            this.btngenbill.Click += new System.EventHandler(this.btngenbill_Click);
            // 
            // btninvoice
            // 
            this.btninvoice.BackColor = System.Drawing.Color.White;
            this.btninvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvoice.Location = new System.Drawing.Point(491, 268);
            this.btninvoice.Name = "btninvoice";
            this.btninvoice.Size = new System.Drawing.Size(136, 35);
            this.btninvoice.TabIndex = 45;
            this.btninvoice.Text = "Show Invoice";
            this.btninvoice.UseVisualStyleBackColor = false;
            this.btninvoice.Click += new System.EventHandler(this.btninvoice_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(794, -1);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(19, 18);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // btnshowcustomer
            // 
            this.btnshowcustomer.BackColor = System.Drawing.Color.White;
            this.btnshowcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowcustomer.Location = new System.Drawing.Point(645, 377);
            this.btnshowcustomer.Name = "btnshowcustomer";
            this.btnshowcustomer.Size = new System.Drawing.Size(151, 45);
            this.btnshowcustomer.TabIndex = 47;
            this.btnshowcustomer.Text = "View Customer\'s Record";
            this.btnshowcustomer.UseVisualStyleBackColor = false;
            this.btnshowcustomer.Click += new System.EventHandler(this.btnshowcustomer_Click);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(816, 504);
            this.ControlBox = false;
            this.Controls.Add(this.btnshowcustomer);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btninvoice);
            this.Controls.Add(this.btngenbill);
            this.Controls.Add(this.btnaddbill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lbltb);
            this.Controls.Add(this.lblbill);
            this.Controls.Add(this.RTB);
            this.Controls.Add(this.lblorder);
            this.Controls.Add(this.btnpo);
            this.Controls.Add(this.btngoback);
            this.Controls.Add(this.CLB);
            this.Controls.Add(this.gbTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "FoodMenu";
            this.Text = "FoodMenu";
            this.Load += new System.EventHandler(this.FoodMenu_Load);
            this.gbTypes.ResumeLayout(false);
            this.gbTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.CheckBox cbDinner;
        private System.Windows.Forms.CheckBox cbLunch;
        private System.Windows.Forms.CheckBox cbBreakfast;
        private System.Windows.Forms.CheckedListBox CLB;
        private System.Windows.Forms.Button btngoback;
        private System.Windows.Forms.RichTextBox RTB;
        private System.Windows.Forms.Label lblorder;
        private System.Windows.Forms.Button btnpo;
        private System.Windows.Forms.Label lbltb;
        private System.Windows.Forms.Label lblbill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Button btnaddbill;
        private System.Windows.Forms.Button btngenbill;
        private System.Windows.Forms.Button btninvoice;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnshowcustomer;
    }
}