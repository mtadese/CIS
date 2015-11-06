using CIS.Application.Entities;
using CIS.Data.DataAccess;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmBookAppointment : Form
    {
        public frmBookAppointment()
        {
            InitializeComponent();
        }

        private void frmBookAppointment_Load(object sender, EventArgs e)
        {
            Load_ClinicsRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ap = new Appointment()
            {
                Identifier = int.Parse(txtCNum.Text),
                ClinicianName = txtPatConsultant.Text,
                PatientId = int.Parse(txtPid.Text),
                HospitalNumber = int.Parse(txtHospNum.Text),
                PatientName = txtPatname.Text,
                Created = dateTimePicker1.Value,
                Purpose = txtApptPurpose.Text,
                CreatedAt = DateTime.Now
            };

            using (ClinicModel context = new ClinicModel())
            {
                context.Appointments.Add(ap);

                context.SaveChanges();
            }

            MessageBox.Show("Clinic Saved");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Load_ClinicsRecord()
        {
            using (ClinicModel context = new ClinicModel())
            {
                var clinics = context.Clinicians.ToList();
                dgridClinics.DataSource = clinics;
            }
        }

        private void btnLoadClinic_Click(object sender, EventArgs e)
        {
            if (dgridClinics.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgridClinics.SelectedRows[0];
                txtPatConsultant.Text = dr.Cells[0].Value.ToString() + " " + dr.Cells[2].Value.ToString();
                txtCNum.Text = dr.Cells[2].Value.ToString();
            }
        }

        private void dgridClinics_DoubleClick_1(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgridClinics.SelectedRows[0];
            txtPatConsultant.Text = dr.Cells[0].Value.ToString() + " " + dr.Cells[2].Value.ToString();
            txtCNum.Text = dr.Cells[2].Value.ToString();
            grpClinics.Visible = false;
        }

        private void txtPid_Leave(object sender, EventArgs e)
        {
            int patientId = int.Parse(txtPid.Text);
            Patient patient;

            using (ClinicModel context = new ClinicModel())
            {
                patient = context.Patients
                    .Where(x => x.Identifier == patientId)
                    .Single();
            }

            txtHospNum.Text = patient.HospitalNumber.ToString();
            txtPatname.Text = patient.FirstName + " " + patient.LastName;
        }

        private void txtPatConsultant_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatConsultant.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtCNum_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCNum.Text.Any(c => !char.IsNumber(c)))
            {
                e.Cancel = true;
            }
        }

        private void txtPatname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatname.Text))
            {
                e.Cancel = true;
            }
        }
    }
}
