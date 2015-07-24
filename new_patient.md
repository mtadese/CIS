---
title: "new_patient"
author: "Micheal"
date: "Wednesday, April 22, 2015"
output: html_document
---

## Saving a New Patient's Demographics

###//system references 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
###//references for connecting to MySql database
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HIS_Manager
{
    public partial class frmNewPatient : Form
    {
        public frmNewPatient()
        {
            InitializeComponent();
        }
###        //declaration of variables to be used within the program
        string connectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;


###          //connecting string for the C# application to MySql database
        private void frmNewPatient_Load(object sender, EventArgs e)
        {
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();
            
###            //gerenarate and display present date and time in a textbox control
            txtDateReg.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

        }

###                //inserting data from the textbox controls into the MySql database        
        private void button1_Click(object sender, EventArgs e)
        {
###            //conditions for populating mandatory fields before saving into database
            if (txtLname.Text == "") { MessageBox.Show("Mandatory Field is empty: Lastname"); }

            else if (txtFname.Text == "") { MessageBox.Show("Mandatory Field is empty: Firstname"); }

            else if (cmbGender.Text == "") { MessageBox.Show("Mandatory Field is empty: Gender"); }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Patients(hospitalnumber,title,lname,fname,mname,gender,dateofbirth,phone,homeaddress,maritalstatus,date_registered)VALUES(@hospitalnumber,@title,@lname,@fname,@mname,@gender,@dateofbirth,@phone,@homeaddress,@maritalstatus, @dateRegistered)";
                cmd.Parameters.AddWithValue("@hospitalnumber", txtHospNum.Text);
                cmd.Parameters.AddWithValue("@title", cmbtitle.Text);
                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@mname", txtMname.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@dateofbirth", DateTime.Parse(txtDob.Text));
                cmd.Parameters.AddWithValue("@phone", int.Parse(txtPhone.Text));
                cmd.Parameters.AddWithValue("@homeaddress", txtHomeAdd.Text);
                cmd.Parameters.AddWithValue("@maritalstatus", cmbMStatus.Text);
                cmd.Parameters.AddWithValue("@dateRegistered", txtDateReg.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("New Patient Registered");
            }

            this.Close(); 
        }

###            //close this module        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

###         //load up the dateTime control with a calendar to select from
            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDob.Text = Convert.ToString(dateTimePicker1.Value.AddDays(0).ToString("yyyy/MM/dd"));
        }
    }
}