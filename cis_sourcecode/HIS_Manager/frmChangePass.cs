using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HIS_Manager
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        string connectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adap;
        DataSet ds;
        MySqlDataReader dr;

        private void frmChangePass_Load(object sender, EventArgs e)
        {

            connectionString = "Server=127.0.0.1;Database=his_record;Uid=micheal;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();



            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string a = frmViewUsers.tb.Text;

            if (txtPassConfirm.Text == txtPassword.Text)
            {

                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Logins SET password=@password WHERE username = '" + a + "' ;";

                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Password changed successfully");
                this.Close();

            }
            else
            {
                MessageBox.Show("Please confirm Password and Confirm Pasword fields match");
                txtPassword.Text = "";
                txtPassConfirm.Text = "";

            }

            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
