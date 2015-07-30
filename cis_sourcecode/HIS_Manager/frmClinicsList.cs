using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmClinicsList : Form
    {
        public frmClinicsList()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds1, ds;

        public static TextBox clID;

        private void frmClinicsList_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(Properties.Settings.Default.LocalDB);
                con.Open();
                //display list of clinicians in the system
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select clnc_sys_id, clnc_id, title, lastname, specialty from Clinic";
                adap = new SqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "clinicians");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                clID = txtclID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNewC_Click(object sender, EventArgs e)
        {
            //display form to create new clinician
            frmNewClinic create = new frmNewClinic();
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
