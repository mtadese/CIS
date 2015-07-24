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
    public partial class frmClinicsList : Form
    {
        public frmClinicsList()
        {
            InitializeComponent();
        }
        //declaration of variables to be used within the program
        string connectionString;   
        MySqlConnection con;        
        MySqlDataAdapter adap;
        DataSet ds1, ds;

        public static TextBox clID;
        
        private void frmClinicsList_Load(object sender, EventArgs e)
        {
            //connecting string for the C# application to MySql database
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();
            //display list of clinicians in the system
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select clnc_sys_id, clnc_id, title, lastname, specialty from Clinicians";
            adap = new MySqlDataAdapter(cmd);
            ds1 = new DataSet();
            adap.Fill(ds1, "clinicians");
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            clID = txtclID;

        }

        private void btnNewC_Click(object sender, EventArgs e)
        {
            //display form to create new clinician
            frmNewClinician create = new frmNewClinician();
            create.ShowDialog();

        }

        private void btnEditC_Click(object sender, EventArgs e)
        {
            //edit existing clinic
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close this module
            this.Close();

        }

        private void btnBookAppt_Click(object sender, EventArgs e)
        {
            //book new patient-doctor appointment
            frmBookAppointment book = new frmBookAppointment();
            book.ShowDialog();
        }

        
    }
}
