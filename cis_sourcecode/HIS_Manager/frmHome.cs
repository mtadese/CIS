using System;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            //load up the "View Users" module
            frmViewUsers viewUsers = new frmViewUsers();
            viewUsers.ShowDialog();

        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            //load up the "Register New Patient" module
            frmFullPatientList full = new frmFullPatientList();
            full.ShowDialog();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPatient register = new frmNewPatient();
            register.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchPatient search = new frmSearchPatient();
            search.ShowDialog();
        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmNew_User new_user = new frmNew_User();
            new_user.ShowDialog();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNewClinic clinic1 = new frmNewClinic();
            clinic1.ShowDialog();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClinicsList clinic2 = new frmClinicsList();
            clinic2.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.ShowDialog();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmViewUsers frm = new frmViewUsers();
            frm.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
