using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CIS.Data.DataAccess;
using CIS.Application.Entities;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }

        private void frmViewUsers_Load(object sender, EventArgs e)
        {
            Load_Users();
        }

        private void Load_Users()
        {
            using (ClinicModel context = new ClinicModel())
            {
                var users = context.Users.ToList();
                dataGridView1.DataSource = users;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            User user;

            using (ClinicModel context = new ClinicModel())
            {
                user = context.Users
                    .Where(x => x.Identifier.Equals(id))
                    .Single();
            }

            frmChangePass frm = new frmChangePass(user);
            frm.ShowDialog();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmNew_User newUser = new frmNew_User();
            newUser.ShowDialog();
            Refresh();
        }
    }
}
