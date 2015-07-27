using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }
        //declaration of variables to be used within the program
        public static TextBox tb;        
        string connectionString;
        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds1;

        private void frmViewUsers_Load(object sender, EventArgs e)
        {
            tb  = txtpid2 ;

            con = new SqlConnection(CIS.Presentatation.UI.WindowsForms.Properties.Settings.Default.LocalDB);
            con.Open();

            Load_Users();
            
        }

        private void Load_Users()
        {
            try
            {
                //importing data from the MySql database into the users record form
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select Firstname, Lastname, Username, Password, Staff_ID from Logins";
                adap = new SqlDataAdapter(cmd);
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

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            //change password of existing user
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close this module
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //add new user
            frmNew_User newUser = new frmNew_User();
            newUser.ShowDialog();
            this.Refresh();

        }
       
    }
}
