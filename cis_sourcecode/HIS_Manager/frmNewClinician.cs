using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//references for connecting to MySql database
using MySql.Data.MySqlClient;


namespace HIS_Manager
{
    public partial class frmNewClinician : Form
    {
        public frmNewClinician()
        {
            InitializeComponent();
        }
        //declaration of variables to be used within the program
        string connectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;

        private void frmNewClinician_Load(object sender, EventArgs e)
        {
            //connecting string for the C# application to MySql database
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();          
                        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtDateReg.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            //conditions for populating mandatory fields before savin into database
           if (txtCNum.Text == "") { MessageBox.Show("Mandatory Field is empty:Clinician Number"); }

           else if (txtLname.Text == "") { MessageBox.Show("Mandatory Field is empty:Lastname"); }
           else
           {
               //inserting data from the textbox controls into the MySql database
               cmd = con.CreateCommand();
               cmd.CommandText = "INSERT INTO Clinicians(clnc_id, title, lastname, firstname, specialty, department, address, phone, email, date_created)VALUES(@clinicID, @title, @lastname, @firstname, @specialty, @department, @address, @phone, @email, @dateCreated)";
               cmd.Parameters.AddWithValue("@clinicID", txtCNum.Text);
               cmd.Parameters.AddWithValue("@title", cmbtitle.Text);
               cmd.Parameters.AddWithValue("@lastname", txtLname.Text);
               cmd.Parameters.AddWithValue("@firstname", txtFname.Text);
               cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text);
               cmd.Parameters.AddWithValue("@department", txtDept.Text);
               cmd.Parameters.AddWithValue("@address", txtAddress.Text);
               cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
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
