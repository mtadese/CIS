---
title: "update_clinics_record"
author: "Micheal"
date: "Tuesday, May 12, 2015"
output: html_document
---


## Update Clinics' Records

###//system references
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
###//references for connecting to MySql database
using MySql.Data.MySqlClient;

namespace HIS_Manager
{
    public partial class frmEditClinic : Form
    {
        public frmEditClinic()
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
        private void frmClinicianRecord_Load(object sender, EventArgs e)
        {
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();

            Load_ClinicRecord();            
        }

###        //importing data from the MySql database into the clinician record form
        private void Load_ClinicRecord()
        {
            string a = frmClinicsList.clID.Text;
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Clinicians where clnc_sys_id = '" + a + "' ";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtCSysID.Text = Convert.ToString(dr[0]);
                txtCNum.Text = Convert.ToString(dr[1]);
                cmbtitle.Text = Convert.ToString(dr[2]);                
                txtLname.Text = Convert.ToString(dr[3]);
                txtFname.Text = Convert.ToString(dr[4]);
                txtSpecialty.Text = Convert.ToString(dr[5]);
                txtDept.Text = Convert.ToString(dr[6]);
                txtAddress.Text = Convert.ToString(dr[7]);
                txtPhone.Text = Convert.ToString(dr[8]);
                txtEmail.Text = Convert.ToString(dr[9]);

                dr.Close();
            }
         }

###        //close this module
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

###        //update clinician record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            try
            {
                if (txtPhone.Text == "")
                {
                    txtPhone.Text = "0";
                }

                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Clinicians SET clnc_id=@clinicID, title=@title, lastname=@lname, firstname=@fname, specialty=@specialty, department=@department, address=@address, Phone=@Phone, Email=@Email, Date_Amended=@Date_Amended WHERE clnc_sys_id= '" + txtCSysID.Text + "' ;";

                cmd.Parameters.AddWithValue("@clinicID", txtCNum.Text);
                cmd.Parameters.AddWithValue("@title", cmbtitle.Text);
                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("@department", txtDept.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@date_amended", txtDateAmend.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Patient Record Updated");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Patient Record");
            }
        }
    }
}
