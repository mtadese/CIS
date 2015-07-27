using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        //public declaration of Login Form and Patient-Registration Form
        frmLogin login;
        frmNewPatient register;
       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //loading up the login page before the homescreen
            login = new frmLogin();
            
        }

        private void frmHome_Unload(object sender, EventArgs e)
        {       
            //exiting the homescreen an loading the login page
            login.Visible = true;
            login.Show();
        }

                             
        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            //load up the "Register New Patient" module
            frmNewPatient register = new frmNewPatient();
            register.ShowDialog();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            //load up the "Find Patient" module
            frmSearchPat search = new frmSearchPat();
            search.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            //load up the "Create New User" module
            frmNew_User new_user = new frmNew_User();
            new_user.ShowDialog();
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

        private void btnNewClinic_Click(object sender, EventArgs e)
        {
            //load up the "Create New Clinic" module
            frmNewClinician clinic1 = new frmNewClinician();
            clinic1.ShowDialog();

        }

        private void btnMangClinic_Click(object sender, EventArgs e)
        {
            //load up the "View Clinics" module
            frmClinicsList clinic2 = new frmClinicsList();
            clinic2.ShowDialog();

        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Closing the homescreen page
            login.Visible = true;
            login.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //load up the "About" module
            frmAbout About = new frmAbout();
            About.ShowDialog();            
        }

             

        

        
    }
}
