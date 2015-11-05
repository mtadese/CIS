using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CIS.Data.DataAccess;
using CIS.Application.Entities;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmSearchPatient : Form
    {
        public frmSearchPatient()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            List<Patient> patients = new List<Patient>();

            using (ClinicModel context = new ClinicModel())
            {
                var patientsQuery = context.Patients.AsQueryable();

                if (txtPatientId.Text.Trim().Length > 0)
                {
                    patientsQuery = patientsQuery.Where(x => x.Identifier == int.Parse(txtPatientId.Text));
                }

                if (txtLastName.Text.Trim().Length > 0)
                {
                    patientsQuery = patientsQuery.Where(x => x.LastName == txtLastName.Text);
                }

                if (txtFirstName.Text.Trim().Length > 0)
                {
                    patientsQuery = patientsQuery.Where(x => x.FirstName == txtFirstName.Text);
                }

                if (txtHospNum.Text.Trim().Length > 0)
                {
                    patientsQuery = patientsQuery.Where(x => x.HospitalNumber == int.Parse(txtHospNum.Text));
                }

                patients = patientsQuery.ToList();
            }

            if (patients.Count == 0)
            {
                MessageBox.Show("No Patient Found");
                return;
            }

            dgvPatients.DataSource = patients;
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvPatients.SelectedRows[0];
                frmPatientRecord frm = new frmPatientRecord(dr);
                frm.Show();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPatients.SelectedRows[0];
            frmPatientRecord frm = new frmPatientRecord(dr);
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
