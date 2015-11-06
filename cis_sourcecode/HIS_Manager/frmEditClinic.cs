using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CIS.Application.Entities;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmEditClinic : Form
    {
        private Clinic _clinic;

        public frmEditClinic()
        {
            InitializeComponent();
        }

        public frmEditClinic(Clinic clinic) : this()
        {
            this._clinic = clinic;
        }

        //declaration of variables to be used within the program
        string connectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader dr;

        private void frmClinicianRecord_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(CIS.Presentation.UI.WindowsForms.Properties.Settings.Default.LocalDB);
            con.Open();

            Load_ClinicRecord();

        }

        private void Load_ClinicRecord()
        {
            txtCSysID.Text = _clinic.Identifier.ToString();
            txtCNum.Text = _clinic.InternalCode;
            cmbtitle.Text = _clinic.Title.ToString();
            txtLname.Text = _clinic.LastName;
            txtFname.Text = _clinic.FirstName;
            txtSpecialty.Text = _clinic.Specialty;
            txtDept.Text = _clinic.Department;
            txtAddress.Text = _clinic.Address;
            txtPhone.Text = _clinic.Telephone;
            txtEmail.Text = _clinic.Email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close this module
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            //update clinician record
            try
            {

                if (txtPhone.Text == "")
                {
                    txtPhone.Text = "0";
                }

                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Clinicians SET clnc_id=@clinicID, title=@title, lastname=@lname, firstname=@fname, specialty=@specialty, department=@department, address=@address, Phone=@Phone, Email=@Email, Date_Amended=@Date_Amended WHERE clnc_sys_id= '" + txtCSysID.Text + "' ;";

                cmd.Parameters.AddWithValue("@clinicID", txtCNum.Text);
                cmd.Parameters.AddWithValue("@title", cmbtitle.Text);
                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("@department", txtDept.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@date_amended", txtDateAmend.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Patient Record Updated");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Patient Record");
            }
        }
    }
}
