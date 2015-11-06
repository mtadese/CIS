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
            try
            {
                txtDateReg.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                //conditions for populating mandatory fields before saving into database
                if (txtPatConsultant.Text == "") { MessageBox.Show("Mandatory Field is empty: Consultant"); }
                else if (txtCNum.Text == "") { MessageBox.Show("Mandatory Field is empty: Consultant Number"); }
                else if (txtPatname.Text == "") { MessageBox.Show("Mandatory Field is empty: Patient Name"); }

                var ap = new Appointment()
                {
                    Identifier = int.Parse(txtCNum.Text),
                    ClinicianName = txtPatConsultant.Text,
                    PatientId = int.Parse(txtPid.Text),
                    HospitalNumber = int.Parse(txtHospNum.Text),
                    PatientName = txtPatname.Text,
                    Created = dateTimePicker1.Value,
                    Purpose = txtApptPurpose.Text,
                    CreatedAt = DateTime.Parse(txtDateReg.Text)
                };

                using (ClinicModel context = new ClinicModel())
                {
                    context.Appointments.Add(ap);

                    context.SaveChanges();
                }

                MessageBox.Show("Clinic Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Book Appointment");
            }

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
    }
}
