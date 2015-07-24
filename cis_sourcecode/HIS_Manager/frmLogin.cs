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
using MySql.Web;

namespace HIS_Manager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //declaration of variables to be used within the program
        string connectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        frmHome homepage;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //connecting string for the C# application to MySql database
            connectionString = "Server=localhost;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();

            homepage = new frmHome();
    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //checking the inputed username and password with the database users' record
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Logins where username = '"+ txtUsername.Text +"' and password= '" + txtPassword.Text + "' ";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                //MessageBox.Show("Login Granted");
                homepage.Show();
                this.Visible = false ;

                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login Details! Try Again");
                txtUsername.Clear();
                txtPassword.Clear();
                con.Close();
                con.Open();

            }

        }

        public void dBase_Connection()
        {
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=micheal;Pwd=password;";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exiting the application
            Application.Exit();

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
