using CIS.Application.Entities;
using CIS.Data.DataAccess;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmNewClinic : Form
    {
        public frmNewClinic()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clinic clinic = new Clinic()
            {
                Identifier = int.Parse(txtClinicNumber.Text),
                Title = (Title)Enum.Parse(typeof(Title), cboTitle.Text),
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Specialty = txtSpecialty.Text,
                Department = txtDepartment.Text,
                Address = txtAddress.Text,
                Telephone = txtTelephone.Text,
                Email = txtEmail.Text,
                CreatedAt = DateTime.Now
            };

            using (ClinicModel context = new ClinicModel())
            {
                context.Clinicians.Add(clinic);

                context.SaveChanges();
            }

            MessageBox.Show("Clinic Saved");

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtClinicNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClinicNumber.Text) || txtClinicNumber.Text.Any(c => !char.IsNumber(c)))
            {
                e.Cancel = true;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || txtLastName.Text.Any(c => !char.IsLetter(c)))
            {
                e.Cancel = true;
            }
        }
    }
}
