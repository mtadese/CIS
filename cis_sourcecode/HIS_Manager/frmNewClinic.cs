using CIS.Presentation.Logic.Presenter;
using CIS.Presentation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmNewClinic : Form, INewClinicView
    {
        private NewClinicPresenter _presenter;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public frmNewClinic()
        {
            InitializeComponent();

            this._presenter = new NewClinicPresenter(this);
        }

        private void frmNewClinic_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(Properties.Settings.Default.LocalDB);
            con.Open();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtClinicNumber.Text == "") { MessageBox.Show("Mandatory Field is empty:Clinician Number"); }

            else if (txtLastName.Text == "") { MessageBox.Show("Mandatory Field is empty:Lastname"); }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Clinicians(clnc_id, title, lastname, firstname, specialty, department, address, phone, email, date_created)VALUES(@clinicID, @title, @lastname, @firstname, @specialty, @department, @address, @phone, @email, @dateCreated)";
                cmd.Parameters.AddWithValue("@clinicID", txtClinicNumber.Text);
                cmd.Parameters.AddWithValue("@title", cboTitle.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtTelephone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@dateCreated", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Clinic Saved");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadTitles()
        {
            throw new NotImplementedException();
        }

        public NewClinicPresentationModel Save()
        {
            return new NewClinicPresentationModel() 
            {
                Address = this.txtAddress.Text,
                Department = this.txtDepartment.Text,
                Email = this.txtEmail.Text,
                FirstName = this.txtFirstName.Text,
                InternalCode = this.txtClinicNumber.Text,
                LastName = this.txtLastName.Text,
                Specialty = this.txtSpecialty.Text,
                Telephone = this.txtTelephone.Text,
                Title = this.cboTitle.SelectedIndex
            };
        }
    }
}
