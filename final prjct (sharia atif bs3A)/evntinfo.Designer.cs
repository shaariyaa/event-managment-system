namespace final_prjct
{
    partial class evntinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(evntinfo));
            this.lblEventid = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lblSheduledid = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEventid
            // 
            this.lblEventid.AutoSize = true;
            this.lblEventid.Location = new System.Drawing.Point(1, -70);
            this.lblEventid.Name = "lblEventid";
            this.lblEventid.Size = new System.Drawing.Size(0, 13);
            this.lblEventid.TabIndex = 15;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(-50, -70);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(46, 13);
            this.Label13.TabIndex = 14;
            this.Label13.Text = "EventID";
            // 
            // lblSheduledid
            // 
            this.lblSheduledid.AutoSize = true;
            this.lblSheduledid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSheduledid.Location = new System.Drawing.Point(-122, -68);
            this.lblSheduledid.Name = "lblSheduledid";
            this.lblSheduledid.Size = new System.Drawing.Size(0, 15);
            this.lblSheduledid.TabIndex = 13;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(-158, -68);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(18, 13);
            this.Label12.TabIndex = 12;
            this.Label12.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 19;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GroupBox2.BackgroundImage")));
            this.GroupBox2.Controls.Add(this.dtpTo);
            this.GroupBox2.Controls.Add(this.dtpFrom);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.label2);
            this.GroupBox2.Location = new System.Drawing.Point(129, 169);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(212, 131);
            this.GroupBox2.TabIndex = 23;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search By Date...";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(387, 265);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 35);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Add";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(48, 69);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(99, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(46, 30);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(99, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 71);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(23, 13);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From:";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.combobox1);
            this.groupBox3.Controls.Add(this.textbox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(129, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 100);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter Event  Detail...";
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Location = new System.Drawing.Point(82, 61);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(164, 21);
            this.combobox1.TabIndex = 3;
            this.combobox1.SelectedIndexChanged += new System.EventHandler(this.txtEvent_Code_TextChanged);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(82, 28);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(118, 20);
            this.textbox1.TabIndex = 2;
            this.textbox1.TextChanged += new System.EventHandler(this.txtEvent_Code_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Event Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Event Code:";
            // 
            // evntinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 333);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEventid);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.lblSheduledid);
            this.Controls.Add(this.Label12);
            this.Name = "evntinfo";
            this.Text = "evntinfo";
            this.Load += new System.EventHandler(this.evntinfo_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblEventid;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label lblSheduledid;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.DateTimePicker dtpTo;
        internal System.Windows.Forms.DateTimePicker dtpFrom;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.ComboBox combobox1;
        internal System.Windows.Forms.TextBox textbox1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
    }
}