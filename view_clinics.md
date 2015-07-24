---
title: "view_clinics"
author: "Micheal"
date: "Tuesday, May 12, 2015"
output: html_document
---

## View Clinics Record

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
    public partial class frmClinicsList : Form
    {
        public frmClinicsList()
        {
            InitializeComponent();
        }
###        //declaration of variables to be used within the program
        string connectionString;   
        MySqlConnection con;        
        MySqlDataAdapter adap;
        DataSet ds1, ds;

        public static TextBox clID;
        
###        //connection string for the C# application to MySql database
        private void frmClinicsList_Load(object sender, EventArgs e)
        {
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();
###            //display list of clinicians in the system
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select clnc_sys_id, clnc_id, title, lastname, specialty from Clinicians";
            adap = new MySqlDataAdapter(cmd);
            ds1 = new DataSet();
            adap.Fill(ds1, "clinicians");
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            clID = txtclID;

        }

###        //display form to create new clinician
        private void btnNewC_Click(object sender, EventArgs e)
        {
            frmNewClinician create = new frmNewClinician();
            create.ShowDialog();
        }

###        //edit existing clinic
        private void btnEditC_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtclID.Text = dr.Cells[0].Value.ToString();

                frmEditClinic create2 = new frmEditClinic();
                create2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Selected Clinic");
            }
        }

###        //close this module
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

###        //book new patient-doctor appointment
        private void btnBookAppt_Click(object sender, EventArgs e)
        {
            frmBookAppointment book = new frmBookAppointment();
            book.ShowDialog();
        }

        
    }
}
