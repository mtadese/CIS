using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmBookAppointment : Form
    {
        public frmBookAppointment()
        {
            InitializeComponent();
        }
        //declaration of variables to be used within the program
        string connectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader dr;

        private void frmBookAppointment_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(CIS.Presentation.UI.WindowsForms.Properties.Settings.Default.LocalDB);
            con.Open();

            Load_ClinicsRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtDateReg.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                //conditions for populating mandatory fields before saving into database
                if (txtPatConsultant.Text == "") { MessageBox.Show("Mandatory Field is empty: Consultant"); }
                else if (txtCNum.Text == "") { MessageBox.Show("Mandatory Field is empty: Consultant Number"); }
                else if (txtPatname.Text == "") { MessageBox.Show("Mandatory Field is empty: Patient Name"); }
                else if (txtApptDate.Text == "") { MessageBox.Show("Mandatory Field is empty: Date of Appointment"); }
                else if (cmbApptTime.Text == "00:00:00") { MessageBox.Show("Mandatory Field is empty: Time of Appointment"); }

                else
                    //inserting data from the textbox controls into the MySql database
                    cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO appointment(clinician_id, clinician_name, patient_id, hospital_number, patient_name, date_of_appointment, time_of_appointment, purpose_of_appointment, date_created)VALUES(@clinicID, @clinicianName, @patientID, @hospitalNumber, @patientName, @apptDate, @apptTime, @apptPurpose, @dateCreated)";
                cmd.Parameters.AddWithValue("@clinicID", txtCNum.Text);
                cmd.Parameters.AddWithValue("@clinicianName", txtPatConsultant.Text);
                cmd.Parameters.AddWithValue("@patientID", txtPid.Text);
                cmd.Parameters.AddWithValue("@hospitalNumber", txtHospNum.Text);
                cmd.Parameters.AddWithValue("@patientName", txtPatname.Text);
                cmd.Parameters.AddWithValue("@apptDate", txtApptDate.Text);
                cmd.Parameters.AddWithValue("@apptTime", cmbApptTime.Text);
                cmd.Parameters.AddWithValue("@apptPurpose", txtApptPurpose.Text);
                cmd.Parameters.AddWithValue("@dateCreated", txtDateReg.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Clinic Saved");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Book Appointment");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close this module
            this.Close();
        }

        private void Load_ClinicsRecord()
        {
            //function to import clinicians record to select for booking appointment
            cmd = con.CreateCommand();
            cmd.CommandText = "Select title, lastname, clnc_id  from Clinic";
            adap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds, "clinicians");
            dgridClinics.DataSource = ds.Tables[0];
            dgridClinics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnLoadClinic_Click(object sender, EventArgs e)
        {
            //display clinicians records to select for booking appointment
            {
                try
                {
                    DataGridViewRow dr = dgridClinics.SelectedRows[0];
                    txtPatConsultant.Text = dr.Cells[0].Value.ToString() + " " + dr.Cells[1].Value.ToString();
                    txtCNum.Text = dr.Cells[2].Value.ToString();
                    grpClinics.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Clinics");
                }
            }
        }

        private void btnSearchClinic_Click(object sender, EventArgs e)
        {
            //make clinician gridview control visible
            grpClinics.Visible = true;
            grpClinics.Left = 100; ;
            grpClinics.Top = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpClinics.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //display calendar control
            txtApptDate.Text = Convert.ToString(dateTimePicker1.Value.AddDays(0).ToString("yyyy/MM/dd"));
        }

        private void dgridClinics_DoubleClick_1(object sender, EventArgs e)
        {
            //select preferred clinician by double-clicking
            {
                try
                {
                    DataGridViewRow dr = dgridClinics.SelectedRows[0];
                    txtPatConsultant.Text = dr.Cells[0].Value.ToString() + " " + dr.Cells[1].Value.ToString();
                    txtCNum.Text = dr.Cells[2].Value.ToString();
                    grpClinics.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Clinics");
                }
            }
        }

        private void txtPid_Leave(object sender, EventArgs e)
        {
            //display patient full name from inputed patient ID
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select hospitalNumber, lName, fName from Patient where Patient_ID = '" + txtPid.Text + "' ";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //txtPid.Text = Convert.ToString(dr[0]);
                    txtHospNum.Text = Convert.ToString(dr[0]);
                    txtPatname.Text = Convert.ToString(dr[1]) + " " + Convert.ToString(dr[2]);

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Book Appointment");
            }
        }


    }
}
