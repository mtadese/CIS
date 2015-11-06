namespace CIS.Presentation.UI.WindowsForms
{
    partial class frmClinicsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClinicsList));
            this.dgvClinicians = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBookAppt = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinicians)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClinicians
            // 
            this.dgvClinicians.AllowUserToAddRows = false;
            this.dgvClinicians.AllowUserToDeleteRows = false;
            this.dgvClinicians.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClinicians.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvClinicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClinicians.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClinicians.Location = new System.Drawing.Point(12, 12);
            this.dgvClinicians.MultiSelect = false;
            this.dgvClinicians.Name = "dgvClinicians";
            this.dgvClinicians.ReadOnly = true;
            this.dgvClinicians.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClinicians.Size = new System.Drawing.Size(365, 150);
            this.dgvClinicians.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(21, 168);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Add New Clinic";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNewC_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(123, 168);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Clinic";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEditC_Click);
            // 
            // btnBookAppt
            // 
            this.btnBookAppt.Location = new System.Drawing.Point(204, 168);
            this.btnBookAppt.Name = "btnBookAppt";
            this.btnBookAppt.Size = new System.Drawing.Size(109, 23);
            this.btnBookAppt.TabIndex = 3;
            this.btnBookAppt.Text = "Book Appointment";
            this.btnBookAppt.UseVisualStyleBackColor = true;
            this.btnBookAppt.Click += new System.EventHandler(this.btnBookAppt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmClinicsList
            // 
            this.ClientSize = new System.Drawing.Size(389, 201);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBookAppt);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvClinicians);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClinicsList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinicians List";
            this.Load += new System.EventHandler(this.frmClinicsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinicians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClinicians;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBookAppt;
        private System.Windows.Forms.Button btnCancel;
    }
}