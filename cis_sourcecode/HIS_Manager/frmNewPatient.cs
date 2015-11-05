using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CIS.Data.DataAccess;
using CIS.Application.Entities;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmNewPatient : Form
    {
        public frmNewPatient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var patient = new Patient
            {
                HospitalNumber = int.Parse(mtbHospitalId.Text),
                Title = (Title)Enum.Parse(typeof(Title), cboTitle.Text),
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                OtherName = txtMname.Text,
                Gender = (Gender)Enum.Parse(typeof(Gender), cboTitle.Text),
                BirthDate = dtpBirthDate.Value,
                Phone = int.Parse(mtbPhone.Text),
                HomeAddress = txtHomeAdd.Text,
                MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), cboMaritalStatus.Text)
            };

            using (ClinicModel model = new ClinicModel())
            {
                model.Patients.Add(patient);
            }

            MessageBox.Show("New Patient Registered");

            Close();
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text.Trim().Length != 0 && txtLastName.Text.Any(c => !char.IsLetter(c)))
            {
                e.Cancel = true;
                MessageBox.Show("Mandatory Field is empty: Lastname");
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text.Trim().Length > 0 && txtLastName.Text.Any(c => !char.IsLetter(c)))
            {
                e.Cancel = true;
                MessageBox.Show("Mandatory Field is empty: Firstname");
            }
        }

        private void cboGender_Validating(object sender, CancelEventArgs e)
        {
            if (cboGender.SelectedIndex > 0)
            {
                e.Cancel = true;
                MessageBox.Show("Mandatory Field is empty: Gender");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
