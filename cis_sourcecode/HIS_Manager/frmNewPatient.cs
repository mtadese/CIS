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
    public partial class frmNewPatient : Form
    {
        public frmNewPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conditions for populating mandatory fields before saving into database
            if (txtLastName.Text == "") { MessageBox.Show("Mandatory Field is empty: Lastname"); }

            else if (txtFirstName.Text == "") { MessageBox.Show("Mandatory Field is empty: Firstname"); }

            else if (cboGender.Text == "") { MessageBox.Show("Mandatory Field is empty: Gender"); }
            else
            {
                //inserting data from the textbox controls into the MySql database
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Patients(hospitalnumber,title,lname,fname,mname,gender,dateofbirth,phone,homeaddress,maritalstatus,date_registered)VALUES(@hospitalnumber,@title,@lname,@fname,@mname,@gender,@dateofbirth,@phone,@homeaddress,@maritalstatus, @dateRegistered)";
                cmd.Parameters.AddWithValue("@hospitalnumber", mtbHospitalId.Text);
                cmd.Parameters.AddWithValue("@title", cboTitle.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@mname", txtMname.Text);
                cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@dateofbirth", DateTime.Parse(txtDob.Text));
                cmd.Parameters.AddWithValue("@phone", int.Parse(txtPhone.Text));
                cmd.Parameters.AddWithValue("@homeaddress", txtHomeAdd.Text);
                cmd.Parameters.AddWithValue("@maritalstatus", cboMaritalStatus.Text);
                cmd.Parameters.AddWithValue("@dateRegistered", DateTime.Now);

                cmd.ExecuteNonQuery();
            }

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

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
