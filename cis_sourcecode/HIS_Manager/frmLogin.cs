using CIS.Application.Entities;
using CIS.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();

            using (ClinicModel context = new ClinicModel())
            {
                users = context.Users
                    .Where(x => x.Username == txtUsername.Text)
                    .ToList();
            }

            if (users.Count == 0)
            {
                DialogResult = DialogResult.No;
                Close();
            }
            else
            {
                User user = users.Single(); 

                if (user.Password.Equals(txtPassword.Text))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    DialogResult = DialogResult.No;
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
