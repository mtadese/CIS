namespace CIS.Presentation.UI.WindowsForms
{
    partial class frmBookAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookAppointment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchClinic = new System.Windows.Forms.Button();
            this.txtPatConsultant = new System.Windows.Forms.TextBox();
            this.txtCNum = new System.Windows.Forms.TextBox();
            this.txtPatname = new System.Windows.Forms.TextBox();
            this.txtHospNum = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.txtApptPurpose = new System.Windows.Forms.TextBox();
            this.grpClinics = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadClinic = new System.Windows.Forms.Button();
            this.dgridClinics = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpClinics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridClinics)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinician Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clinician ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hospital  Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patient Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Appointment Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Purpose";
            // 
            // btnSearchClinic
            // 
            this.btnSearchClinic.Location = new System.Drawing.Point(295, 12);
            this.btnSearchClinic.Name = "btnSearchClinic";
            this.btnSearchClinic.Size = new System.Drawing.Size(49, 23);
            this.btnSearchClinic.TabIndex = 88;
            this.btnSearchClinic.Text = "Search";
            this.btnSearchClinic.UseVisualStyleBackColor = true;
            // 
            // txtPatConsultant
            // 
            this.txtPatConsultant.Location = new System.Drawing.Point(124, 14);
            this.txtPatConsultant.Name = "txtPatConsultant";
            this.txtPatConsultant.Size = new System.Drawing.Size(165, 20);
            this.txtPatConsultant.TabIndex = 87;
            this.txtPatConsultant.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatConsultant_Validating);
            // 
            // txtCNum
            // 
            this.txtCNum.Location = new System.Drawing.Point(124, 40);
            this.txtCNum.Name = "txtCNum";
            this.txtCNum.Size = new System.Drawing.Size(165, 20);
            this.txtCNum.TabIndex = 89;
            this.txtCNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNum_Validating);
            // 
            // txtPatname
            // 
            this.txtPatname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatname.Location = new System.Drawing.Point(124, 118);
            this.txtPatname.Name = "txtPatname";
            this.txtPatname.Size = new System.Drawing.Size(220, 20);
            this.txtPatname.TabIndex = 92;
            this.txtPatname.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatname_Validating);
            // 
            // txtHospNum
            // 
            this.txtHospNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospNum.Location = new System.Drawing.Point(124, 92);
            this.txtHospNum.Name = "txtHospNum";
            this.txtHospNum.Size = new System.Drawing.Size(220, 20);
            this.txtHospNum.TabIndex = 91;
            // 
            // txtPid
            // 
            this.txtPid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPid.Location = new System.Drawing.Point(124, 66);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(220, 20);
            this.txtPid.TabIndex = 90;
            this.txtPid.Leave += new System.EventHandler(this.txtPid_Leave);
            // 
            // txtApptPurpose
            // 
            this.txtApptPurpose.Location = new System.Drawing.Point(124, 197);
            this.txtApptPurpose.Multiline = true;
            this.txtApptPurpose.Name = "txtApptPurpose";
            this.txtApptPurpose.Size = new System.Drawing.Size(220, 55);
            this.txtApptPurpose.TabIndex = 97;
            // 
            // grpClinics
            // 
            this.grpClinics.BackColor = System.Drawing.Color.DarkGray;
            this.grpClinics.Controls.Add(this.label37);
            this.grpClinics.Controls.Add(this.button1);
            this.grpClinics.Controls.Add(this.btnLoadClinic);
            this.grpClinics.Controls.Add(this.dgridClinics);
            this.grpClinics.Location = new System.Drawing.Point(350, 12);
            this.grpClinics.Name = "grpClinics";
            this.grpClinics.Size = new System.Drawing.Size(237, 270);
            this.grpClinics.TabIndex = 98;
            this.grpClinics.TabStop = false;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Navy;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label37.Location = new System.Drawing.Point(3, 10);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(234, 18);
            this.label37.TabIndex = 20;
            this.label37.Text = "Clinicians";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLoadClinic
            // 
            this.btnLoadClinic.Location = new System.Drawing.Point(176, 31);
            this.btnLoadClinic.Name = "btnLoadClinic";
            this.btnLoadClinic.Size = new System.Drawing.Size(55, 25);
            this.btnLoadClinic.TabIndex = 18;
            this.btnLoadClinic.Text = "Select";
            this.btnLoadClinic.UseVisualStyleBackColor = true;
            this.btnLoadClinic.Click += new System.EventHandler(this.btnLoadClinic_Click);
            // 
            // dgridClinics
            // 
            this.dgridClinics.AllowUserToAddRows = false;
            this.dgridClinics.AllowUserToDeleteRows = false;
            this.dgridClinics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgridClinics.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgridClinics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridClinics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgridClinics.Location = new System.Drawing.Point(6, 31);
            this.dgridClinics.MultiSelect = false;
            this.dgridClinics.Name = "dgridClinics";
            this.dgridClinics.ReadOnly = true;
            this.dgridClinics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridClinics.Size = new System.Drawing.Size(164, 233);
            this.dgridClinics.TabIndex = 17;
            this.dgridClinics.DoubleClick += new System.EventHandler(this.dgridClinics_DoubleClick_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 94;
            // 
            // frmBookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 288);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpClinics);
            this.Controls.Add(this.txtApptPurpose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPatname);
            this.Controls.Add(this.txtHospNum);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.txtCNum);
            this.Controls.Add(this.btnSearchClinic);
            this.Controls.Add(this.txtPatConsultant);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookAppointment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookAppointment";
            this.Load += new System.EventHandler(this.frmBookAppointment_Load);
            this.grpClinics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridClinics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchClinic;
        private System.Windows.Forms.TextBox txtPatConsultant;
        private System.Windows.Forms.TextBox txtCNum;
        private System.Windows.Forms.TextBox txtPatname;
        private System.Windows.Forms.TextBox txtHospNum;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtApptPurpose;
        private System.Windows.Forms.GroupBox grpClinics;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadClinic;
        private System.Windows.Forms.DataGridView dgridClinics;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}