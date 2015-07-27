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

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmFullPatientList : Form
    {
        public frmFullPatientList()
        {
            InitializeComponent();
        }

        //declaration of variables to be used within the program
        string connectionString;
        MySqlConnection con;
        MySqlDataAdapter adap;
        DataSet ds1;

        
        private void frmFullPatientList_Load(object sender, EventArgs e)
        {
            //connecting string for the C# application to MySql database
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();

            Load_Users();
        }

        private void Load_Users()
        {
            //display all patients' demographics on a gridview control
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Patients";
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

        private void button1_Click(object sender, EventArgs e)
        {          

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close this module
            this.Close();
        }

       
    }
}
