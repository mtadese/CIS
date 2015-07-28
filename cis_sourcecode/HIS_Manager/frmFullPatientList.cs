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
    public partial class frmFullPatientList : Form
    {
        public frmFullPatientList()
        {
            InitializeComponent();
        }

        //declaration of variables to be used within the program
        string connectionString;
        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds1;

        
        private void frmFullPatientList_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(CIS.Presentation.UI.WindowsForms.Properties.Settings.Default.LocalDB);
            con.Open();

            Load_Users();
        }

        private void Load_Users()
        {
            //display all patients' demographics on a gridview control
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Patients";
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
