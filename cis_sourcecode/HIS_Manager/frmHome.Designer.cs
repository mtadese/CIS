namespace CIS.Presentation.UI.WindowsForms
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnPatientList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClinician = new System.Windows.Forms.Button();
            this.btnNewClinic = new System.Windows.Forms.Button();
            this.btnMangClinic = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisterPatient
            // 
            this.btnRegisterPatient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRegisterPatient.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegisterPatient.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterPatient.Location = new System.Drawing.Point(163, 92);
            this.btnRegisterPatient.Name = "btnRegisterPatient";
            this.btnRegisterPatient.Size = new System.Drawing.Size(126, 50);
            this.btnRegisterPatient.TabIndex = 0;
            this.btnRegisterPatient.Text = "Register New Patient";
            this.btnRegisterPatient.UseVisualStyleBackColor = false;
            this.btnRegisterPatient.Click += new System.EventHandler(this.btnRegisterPatient_Click);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchPatient.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearchPatient.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatient.Location = new System.Drawing.Point(163, 149);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(126, 49);
            this.btnSearchPatient.TabIndex = 1;
            this.btnSearchPatient.Text = "Find Patient";
            this.btnSearchPatient.UseVisualStyleBackColor = false;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(10, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "System Admin";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(799, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button6.BackColor = System.Drawing.Color.Navy;
            this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(12, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 80);
            this.button6.TabIndex = 5;
            this.button6.Text = "Patient Record";
            this.button6.UseVisualStyleBackColor = false;
            
            // 
            // btnNewUser
            // 
            this.btnNewUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewUser.BackColor = System.Drawing.Color.Tan;
            this.btnNewUser.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Location = new System.Drawing.Point(161, 260);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(126, 48);
            this.btnNewUser.TabIndex = 6;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewUsers.BackColor = System.Drawing.Color.Tan;
            this.btnViewUsers.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUsers.Location = new System.Drawing.Point(161, 314);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(126, 47);
            this.btnViewUsers.TabIndex = 7;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = false;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnPatientList
            // 
            this.btnPatientList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPatientList.BackColor = System.Drawing.Color.Tan;
            this.btnPatientList.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientList.Location = new System.Drawing.Point(161, 367);
            this.btnPatientList.Name = "btnPatientList";
            this.btnPatientList.Size = new System.Drawing.Size(126, 47);
            this.btnPatientList.TabIndex = 8;
            this.btnPatientList.Text = "Full Patient List";
            this.btnPatientList.UseVisualStyleBackColor = false;
            this.btnPatientList.Click += new System.EventHandler(this.btnPatientList_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "CLINICAL INFORMATION SYSTEM";
            // 
            // btnClinician
            // 
            this.btnClinician.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClinician.BackColor = System.Drawing.Color.Navy;
            this.btnClinician.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinician.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClinician.Location = new System.Drawing.Point(333, 93);
            this.btnClinician.Name = "btnClinician";
            this.btnClinician.Size = new System.Drawing.Size(145, 80);
            this.btnClinician.TabIndex = 10;
            this.btnClinician.Text = "Clinician Record";
            this.btnClinician.UseVisualStyleBackColor = false;
            // 
            // btnNewClinic
            // 
            this.btnNewClinic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewClinic.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNewClinic.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClinic.Location = new System.Drawing.Point(488, 92);
            this.btnNewClinic.Name = "btnNewClinic";
            this.btnNewClinic.Size = new System.Drawing.Size(126, 50);
            this.btnNewClinic.TabIndex = 11;
            this.btnNewClinic.Text = "Create New Clinic";
            this.btnNewClinic.UseVisualStyleBackColor = false;
            this.btnNewClinic.Click += new System.EventHandler(this.btnNewClinic_Click);
            // 
            // btnMangClinic
            // 
            this.btnMangClinic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMangClinic.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMangClinic.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangClinic.Location = new System.Drawing.Point(488, 149);
            this.btnMangClinic.Name = "btnMangClinic";
            this.btnMangClinic.Size = new System.Drawing.Size(126, 50);
            this.btnMangClinic.TabIndex = 12;
            this.btnMangClinic.Text = "Manage Clinics";
            this.btnMangClinic.UseVisualStyleBackColor = false;
            this.btnMangClinic.Click += new System.EventHandler(this.btnMangClinic_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(799, 30);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(111, 31);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(909, 414);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnMangClinic);
            this.Controls.Add(this.btnNewClinic);
            this.Controls.Add(this.btnClinician);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPatientList);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.btnRegisterPatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIS - Homescreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterPatient;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnPatientList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClinician;
        private System.Windows.Forms.Button btnNewClinic;
        private System.Windows.Forms.Button btnMangClinic;
        private System.Windows.Forms.Button btnAbout;
    }
}