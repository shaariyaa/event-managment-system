namespace final_prjct
{
    partial class evntfees
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpPaid = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtInitialPay = new System.Windows.Forms.TextBox();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.txtOther_Charge = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEventTy = new System.Windows.Forms.TextBox();
            this.txtCustomer_Code = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.lblReciever = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = global::final_prjct.Properties.Resources.download__1_;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.GroupBox2);
            this.Panel1.Location = new System.Drawing.Point(75, 87);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(451, 334);
            this.Panel1.TabIndex = 22;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackgroundImage = global::final_prjct.Properties.Resources.download__1_;
            this.GroupBox1.Controls.Add(this.dtpPaid);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.txtBalance);
            this.GroupBox1.Controls.Add(this.txtInitialPay);
            this.GroupBox1.Controls.Add(this.txtTotalCharge);
            this.GroupBox1.Controls.Add(this.txtOther_Charge);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Location = new System.Drawing.Point(6, 128);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(424, 138);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Payment Details...";
            // 
            // dtpPaid
            // 
            this.dtpPaid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaid.Location = new System.Drawing.Point(97, 88);
            this.dtpPaid.Name = "dtpPaid";
            this.dtpPaid.Size = new System.Drawing.Size(105, 20);
            this.dtpPaid.TabIndex = 11;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(15, 92);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(77, 13);
            this.Label10.TabIndex = 10;
            this.Label10.Text = "Payment Date:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(212, 59);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(49, 13);
            this.Label9.TabIndex = 9;
            this.Label9.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(294, 56);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 8;
            // 
            // txtInitialPay
            // 
            this.txtInitialPay.Location = new System.Drawing.Point(99, 56);
            this.txtInitialPay.Name = "txtInitialPay";
            this.txtInitialPay.Size = new System.Drawing.Size(100, 20);
            this.txtInitialPay.TabIndex = 7;
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Location = new System.Drawing.Point(292, 24);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCharge.TabIndex = 6;
            // 
            // txtOther_Charge
            // 
            this.txtOther_Charge.Location = new System.Drawing.Point(99, 26);
            this.txtOther_Charge.Name = "txtOther_Charge";
            this.txtOther_Charge.Size = new System.Drawing.Size(100, 20);
            this.txtOther_Charge.TabIndex = 5;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(15, 59);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(76, 13);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Intial Payment:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(208, 28);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(71, 13);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Total Charge:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(15, 30);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(73, 13);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Other Charge:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GroupBox2.BackgroundImage = global::final_prjct.Properties.Resources.download__1_;
            this.GroupBox2.Controls.Add(this.txtEventTy);
            this.GroupBox2.Controls.Add(this.txtCustomer_Code);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Location = new System.Drawing.Point(7, 7);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(295, 102);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Customer/Event Info....";
            // 
            // txtEventTy
            // 
            this.txtEventTy.Location = new System.Drawing.Point(98, 60);
            this.txtEventTy.Name = "txtEventTy";
            this.txtEventTy.ReadOnly = true;
            this.txtEventTy.Size = new System.Drawing.Size(163, 20);
            this.txtEventTy.TabIndex = 6;
            // 
            // txtCustomer_Code
            // 
            this.txtCustomer_Code.Location = new System.Drawing.Point(98, 28);
            this.txtCustomer_Code.Name = "txtCustomer_Code";
            this.txtCustomer_Code.Size = new System.Drawing.Size(163, 20);
            this.txtCustomer_Code.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Event Type:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Customer Code:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.Maroon;
            this.Label12.Location = new System.Drawing.Point(176, 37);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(238, 25);
            this.Label12.TabIndex = 21;
            this.Label12.Text = "Event Fees Payment ";
            this.Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // lblReciever
            // 
            this.lblReciever.AutoSize = true;
            this.lblReciever.Location = new System.Drawing.Point(277, 429);
            this.lblReciever.Name = "lblReciever";
            this.lblReciever.Size = new System.Drawing.Size(0, 13);
            this.lblReciever.TabIndex = 19;
            // 
            // evntfees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::final_prjct.Properties.Resources.download__1_;
            this.ClientSize = new System.Drawing.Size(601, 476);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.lblReciever);
            this.Name = "evntfees";
            this.Text = "evntfees";
            this.Panel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DateTimePicker dtpPaid;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtBalance;
        internal System.Windows.Forms.TextBox txtInitialPay;
        internal System.Windows.Forms.TextBox txtTotalCharge;
        internal System.Windows.Forms.TextBox txtOther_Charge;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtEventTy;
        internal System.Windows.Forms.TextBox txtCustomer_Code;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label lblReciever;
    }
}