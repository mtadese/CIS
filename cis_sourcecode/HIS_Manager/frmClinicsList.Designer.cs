namespace HIS_Manager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewC = new System.Windows.Forms.Button();
            this.btnEditC = new System.Windows.Forms.Button();
            this.btnBookAppt = new System.Windows.Forms.Button();
            this.txtclID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(354, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNewC
            // 
            this.btnNewC.Location = new System.Drawing.Point(1, 229);
            this.btnNewC.Name = "btnNewC";
            this.btnNewC.Size = new System.Drawing.Size(96, 23);
            this.btnNewC.TabIndex = 1;
            this.btnNewC.Text = "Add New Clinic";
            this.btnNewC.UseVisualStyleBackColor = true;
            this.btnNewC.Click += new System.EventHandler(this.btnNewC_Click);
            // 
            // btnEditC
            // 
            this.btnEditC.Location = new System.Drawing.Point(103, 229);
            this.btnEditC.Name = "btnEditC";
            this.btnEditC.Size = new System.Drawing.Size(75, 23);
            this.btnEditC.TabIndex = 2;
            this.btnEditC.Text = "Edit Clinic";
            this.btnEditC.UseVisualStyleBackColor = true;
            this.btnEditC.Click += new System.EventHandler(this.btnEditC_Click);
            // 
            // btnBookAppt
            // 
            this.btnBookAppt.Location = new System.Drawing.Point(184, 229);
            this.btnBookAppt.Name = "btnBookAppt";
            this.btnBookAppt.Size = new System.Drawing.Size(109, 23);
            this.btnBookAppt.TabIndex = 3;
            this.btnBookAppt.Text = "Book Appointment";
            this.btnBookAppt.UseVisualStyleBackColor = true;
            this.btnBookAppt.Click += new System.EventHandler(this.btnBookAppt_Click);
            // 
            // txtclID
            // 
            this.txtclID.Location = new System.Drawing.Point(1, 289);
            this.txtclID.Name = "txtclID";
            this.txtclID.Size = new System.Drawing.Size(100, 20);
            this.txtclID.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmClinicsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(356, 257);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtclID);
            this.Controls.Add(this.btnBookAppt);
            this.Controls.Add(this.btnEditC);
            this.Controls.Add(this.btnNewC);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClinicsList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinicians List";
            this.Load += new System.EventHandler(this.frmClinicsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewC;
        private System.Windows.Forms.Button btnEditC;
        private System.Windows.Forms.Button btnBookAppt;
        private System.Windows.Forms.TextBox txtclID;
        private System.Windows.Forms.Button btnCancel;
    }
}