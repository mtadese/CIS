using CIS.Application.Entities;
using CIS.Data.DataAccess;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmChangePass : Form
    {
        private User _user;

        public frmChangePass()
        {
            InitializeComponent();
        }

        public frmChangePass(User user)
            : this()
        {
            _user = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassConfirm.Text == txtPassword.Text)
            {
                _user.Password = txtPassword.Text;

                using (ClinicModel context = new ClinicModel())
                {
                    context.Users.Attach(_user);

                    context.SaveChanges();
                }

                MessageBox.Show("Password changed successfully");

                Close();
            }
            else
            {
                MessageBox.Show("Please confirm Password and Confirm Pasword fields match");
                txtPassword.Text = "";
                txtPassConfirm.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtPassConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassConfirm.Text))
            {
                e.Cancel = true;
            }
        }
    }
}
