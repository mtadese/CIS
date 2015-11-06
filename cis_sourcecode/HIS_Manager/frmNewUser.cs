using CIS.Application.Entities;
using CIS.Data.DataAccess;
using System;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmNew_User : Form
    {
        public frmNew_User()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                FirstName = txtFName.Text,
                LastName = txtLName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                ModuleAccess = txtProfile.Text
            };

            using (ClinicModel context = new ClinicModel())
            {
                context.Users.Add(user);

                context.SaveChanges();
            }

            MessageBox.Show("New User Created");

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
