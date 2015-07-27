using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmViewAppointment : Form
    {
        public frmViewAppointment()
        {
            InitializeComponent();
        }
        string connectionString;
        
        MySqlConnection con;        
        MySqlDataAdapter adap;
        DataSet ds1;
        
        private void frmViewAppointment_Load(object sender, EventArgs e)
        {

            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select appointments_id, clinician_id, clinician_name, date_of_appointment, time_of_appointment, patient_id, hospital_number, patient_name, purpose_of_appointment from Appointments";
            adap = new MySqlDataAdapter(cmd);
            ds1 = new DataSet();
            adap.Fill(ds1, "appointments");
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtApptDate.Text = Convert.ToString(dateTimePicker1.Value.AddDays(0).ToString("yyyy/MM/dd"));
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text == "Appointment Date")
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select appointments_id, clinician_id, clinician_name, date_of_appointment, time_of_appointment, patient_id, hospital_number, patient_name, purpose_of_appointment from Appointments where date_of_appointment = '" + txtApptDate.Text + "' ";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "appointments");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            else if(cmbSearch.Text == "Patient") 
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select appointments_id, clinician_id, clinician_name, date_of_appointment, time_of_appointment, patient_id, hospital_number, patient_name, purpose_of_appointment from Appointments where patient_id = '" + txtPid.Text + "' ";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "appointments");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            //else if(cmbSearch.Text == "Clinician") {


        }
   
        
    }
}
