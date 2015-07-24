---
title: "view_users"
author: "Micheal"
date: "Tuesday, May 12, 2015"
output: html_document
---


## View End-Users' Records

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
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }
###        //declaration of variables to be used within the program
        public static TextBox tb;        
        string connectionString;
        MySqlConnection con;
        MySqlDataAdapter adap;
        DataSet ds1;

###        //connecting string for the C# application to MySql database
        private void frmViewUsers_Load(object sender, EventArgs e)
        {
            tb  = txtpid2 ;
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();

            Load_Users();
            
        }

###        //importing data from the MySql database into the users record form
        private void Load_Users()
        {
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select Firstname, Lastname, Username, Password, Staff_ID from Logins";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "patients");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

###        //change password of existing user
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtpid2.Text = dr.Cells[2].Value.ToString();
                frmChangePass changePass = new frmChangePass();
                changePass.ShowDialog();
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
             
        }

###        //close this module
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

###        //add new user
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmNew_User newUser = new frmNew_User();
            newUser.ShowDialog();
            this.Refresh();

        }
       
    }
}
