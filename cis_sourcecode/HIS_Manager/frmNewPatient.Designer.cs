namespace CIS.Presentation.UI.WindowsForms
{
    partial class frmNewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewPatient));
            this.txtPid = new System.Windows.Forms.TextBox();
            this.txtHospNum = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHomeAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDateReg = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbtitle = new System.Windows.Forms.ComboBox();
            this.cmbMStatus = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPid
            // 
            this.txtPid.BackColor = System.Drawing.Color.White;
            this.txtPid.Location = new System.Drawing.Point(105, 12);
            this.txtPid.Name = "txtPid";
            this.txtPid.ReadOnly = true;
            this.txtPid.Size = new System.Drawing.Size(198, 20);
            this.txtPid.TabIndex = 0;
            this.txtPid.Visible = false;
            // 
            // txtHospNum
            // 
            this.txtHospNum.Location = new System.Drawing.Point(105, 38);
            this.txtHospNum.Name = "txtHospNum";
            this.txtHospNum.Size = new System.Drawing.Size(198, 20);
            this.txtHospNum.TabIndex = 1;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(105, 91);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(198, 20);
            this.txtLname.TabIndex = 3;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(105, 117);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(198, 20);
            this.txtFname.TabIndex = 4;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(105, 143);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(198, 20);
            this.txtMname.TabIndex = 5;
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(105, 196);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(172, 20);
            this.txtDob.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(105, 222);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(198, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient ID";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Other Names";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Home Address";
            // 
            // txtHomeAdd
            // 
            this.txtHomeAdd.Location = new System.Drawing.Point(105, 248);
            this.txtHomeAdd.Multiline = true;
            this.txtHomeAdd.Name = "txtHomeAdd";
            this.txtHomeAdd.Size = new System.Drawing.Size(198, 37);
            this.txtHomeAdd.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hospital Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Marital Status";
            // 
            // txtDateReg
            // 
            this.txtDateReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateReg.Location = new System.Drawing.Point(105, 347);
            this.txtDateReg.Name = "txtDateReg";
            this.txtDateReg.Size = new System.Drawing.Size(198, 20);
            this.txtDateReg.TabIndex = 24;
            this.txtDateReg.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 81;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbtitle
            // 
            this.cmbtitle.FormattingEnabled = true;
            this.cmbtitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss.",
            "Ms.",
            "Dr."});
            this.cmbtitle.Location = new System.Drawing.Point(105, 64);
            this.cmbtitle.Name = "cmbtitle";
            this.cmbtitle.Size = new System.Drawing.Size(64, 21);
            this.cmbtitle.TabIndex = 82;
            // 
            // cmbMStatus
            // 
            this.cmbMStatus.FormattingEnabled = true;
            this.cmbMStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widowed"});
            this.cmbMStatus.Location = new System.Drawing.Point(105, 291);
            this.cmbMStatus.Name = "cmbMStatus";
            this.cmbMStatus.Size = new System.Drawing.Size(122, 21);
            this.cmbMStatus.TabIndex = 85;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(105, 169);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(122, 21);
            this.cmbGender.TabIndex = 84;
            // 
            // frmNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 354);
            this.Controls.Add(this.cmbMStatus);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbtitle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtDateReg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHomeAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtMname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtHospNum);
            this.Controls.Add(this.txtPid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewPatient";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPatient";
            this.Load += new System.EventHandler(this.frmNewPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtHospNum;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHomeAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDateReg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbtitle;
        private System.Windows.Forms.ComboBox cmbMStatus;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}