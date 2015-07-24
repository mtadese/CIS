---
title: "find_patient"
author: "Micheal"
date: "Wednesday, April 22, 2015"
output: html_document
---

## Finding a Patient

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
    public partial class frmSearchPat : Form
    {
        public frmSearchPat()
        {
            InitializeComponent();
        }
###        //declaration of variables to be used within the program
            string connectionString;
            MySqlDataReader dr;
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataAdapter adap;
            DataSet ds1, ds;

            public static TextBox pid;
        
###            //connecting string for the C# application to MySql database
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 155;
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();
           pid = txtpid2;
        }

###            //search for patient with available criteria (id, names, hospital number)
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPid.Text == "" && txtLname.Text == "" && txtFname.Text == "" && txtHospNum.Text == "")
            {
                MessageBox.Show("No Patient Found");
            }

            else if (txtLname.Text == "" )
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Patients where fName= '" + txtFname.Text + "' or Patient_ID = '" + txtPid.Text + "' or HospitalNumber = '" + txtHospNum.Text + "'  ";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "patients");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                this.Height = 320;
            }

            else
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Patients where lName like '" + txtLname.Text + "%" + "' or fName= '" + txtFname.Text + "' or Patient_ID = '" + txtPid.Text + "' or HospitalNumber = '" + txtHospNum.Text + "' ";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "patients");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                txtLname.Clear();
                this.Height = 320;
            }        
        }

###        // close this module
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

###            //load demographics of highlighted patient
        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtpid2.Text = dr.Cells[0].Value.ToString();
            textBox2.Text = dr.Cells[1].Value.ToString();
            frmPatientRecord patrecord = new frmPatientRecord();
            patrecord.Show();            
        }

###        // adjusting size of the module to display search criteria section only
        private void button2_Click(object sender, EventArgs e)
        {
            this.Height = 155;
        }

###            //additional option to select highlighted patient by double-clicking the preferred patient to view
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtpid2.Text = dr.Cells[0].Value.ToString();
            textBox2.Text = dr.Cells[1].Value.ToString();
            frmPatientRecord patrecord = new frmPatientRecord();
            patrecord.Show();

        }       

    }
}
