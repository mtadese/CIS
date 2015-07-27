using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmNewClinician : Form
    {
        public frmNewClinician()
        {
            InitializeComponent();
        }
        //declaration of variables to be used within the program
        string connectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        private void frmNewClinician_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(CIS.Presentatation.UI.WindowsForms.Properties.Settings.Default.LocalDB);
            con.Open();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtDateReg.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            //conditions for populating mandatory fields before savin into database
            if (txtClinicNumber.Text == "") { MessageBox.Show("Mandatory Field is empty:Clinician Number"); }

            else if (txtLastName.Text == "") { MessageBox.Show("Mandatory Field is empty:Lastname"); }
            else
            {
                //inserting data from the textbox controls into the MySql database
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Clinicians(clnc_id, title, lastname, firstname, specialty, department, address, phone, email, date_created)VALUES(@clinicID, @title, @lastname, @firstname, @specialty, @department, @address, @phone, @email, @dateCreated)";
                cmd.Parameters.AddWithValue("@clinicID", txtClinicNumber.Text);
                cmd.Parameters.AddWithValue("@title", cboTitle.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtTelephone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@dateCreated", txtDateReg.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Clinic Saved");
                this.Close();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close this module
            this.Close();
        }





    }
}
