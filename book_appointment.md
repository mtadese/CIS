---
title: "book_appointment"
author: "Micheal"
date: "Tuesday, May 12, 2015"
output: html_document
---


## Book Appointments for Patient/Clinician

###//system references
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
###//references for connecting to MySql database
using MySql.Data.MySqlClient;

namespace HIS_Manager
{
    public partial class frmBookAppointment : Form
    {
        public frmBookAppointment()
        {
            InitializeComponent();
        }
###        //declaration of variables to be used within the program
        string connectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adap;
        DataSet ds;
        MySqlDataReader dr;

###        //connection string for the C# application to MySql database
        private void frmBookAppointment_Load(object sender, EventArgs e)
        {
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();
                        
            Load_ClinicsRecord();
        }

###        //inserting data from the textbox controls into the MySql database
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtDateReg.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
###                //conditions for populating mandatory fields before saving into database
                if (txtPatConsultant.Text == "") { MessageBox.Show("Mandatory Field is empty: Consultant"); }
                else if (txtCNum.Text == "") { MessageBox.Show("Mandatory Field is empty: Consultant Number"); }
                else if (txtPatname.Text == "") { MessageBox.Show("Mandatory Field is empty: Patient Name"); }
                else if (txtApptDate.Text == "") { MessageBox.Show("Mandatory Field is empty: Date of Appointment"); }
                else if (cmbApptTime.Text == "00:00:00") { MessageBox.Show("Mandatory Field is empty: Time of Appointment"); }

                else
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO appointments(clinician_id, clinician_name, patient_id, hospital_number, patient_name, date_of_appointment, time_of_appointment, purpose_of_appointment, date_created)VALUES(@clinicID, @clinicianName, @patientID, @hospitalNumber, @patientName, @apptDate, @apptTime, @apptPurpose, @dateCreated)";
                cmd.Parameters.AddWithValue("@clinicID", txtCNum.Text);
                cmd.Parameters.AddWithValue("@clinicianName", txtPatConsultant.Text);
                cmd.Parameters.AddWithValue("@patientID", txtPid.Text);
                cmd.Parameters.AddWithValue("@hospitalNumber", txtHospNum.Text);
                cmd.Parameters.AddWithValue("@patientName", txtPatname.Text);
                cmd.Parameters.AddWithValue("@apptDate", txtApptDate.Text);
                cmd.Parameters.AddWithValue("@apptTime", cmbApptTime.Text);
                cmd.Parameters.AddWithValue("@apptPurpose", txtApptPurpose.Text);
                cmd.Parameters.AddWithValue("@dateCreated", txtDateReg.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Clinic Saved");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Book Appointment");
            }
               
        }

###        //close this module
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

###        //function to import clinicians record to select for booking appointment
        private void Load_ClinicsRecord()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select title, lastname, clnc_id  from Clinicians";
            adap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds, "clinicians");
            dgridClinics.DataSource = ds.Tables[0];
            dgridClinics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

###        //display clinicians records to select for booking appointment
        private void btnLoadClinic_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    DataGridViewRow dr = dgridClinics.SelectedRows[0];
                    txtPatConsultant.Text = dr.Cells[0].Value.ToString() + " " + dr.Cells[1].Value.ToString();
                    txtCNum.Text = dr.Cells[2].Value.ToString();
                    grpClinics.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Clinics");
                }
            }
        }

###        //make clinician gridview control visible
        private void btnSearchClinic_Click(object sender, EventArgs e)
        {
            grpClinics.Visible = true;
            grpClinics.Left = 100; ;
            grpClinics.Top = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpClinics.Visible = false;
        }
                
###        //display calendar control
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtApptDate.Text = Convert.ToString(dateTimePicker1.Value.AddDays(0).ToString("yyyy/MM/dd"));
        }

###        //select preferred clinician by double-clicking
        private void dgridClinics_DoubleClick_1(object sender, EventArgs e)
        {
            {
                try
                {
                    DataGridViewRow dr = dgridClinics.SelectedRows[0];
                    txtPatConsultant.Text = dr.Cells[0].Value.ToString() + " " + dr.Cells[1].Value.ToString();
                    txtCNum.Text = dr.Cells[2].Value.ToString();
                    grpClinics.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Clinics");
                }
            }
        }                
        
###        //display patient full name from inputed patient ID
        private void txtPid_Leave(object sender, EventArgs e)
        {
            try
            {                
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select hospitalNumber, lName, fName from Patients where Patient_ID = '" + txtPid.Text + "' ";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
###                    //txtPid.Text = Convert.ToString(dr[0]);
                    txtHospNum.Text = Convert.ToString(dr[0]);
                    txtPatname.Text = Convert.ToString(dr[1]) + " " + Convert.ToString(dr[2]);

                    dr.Close();
                }
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Book Appointment");
                }
        }                

    }
}
