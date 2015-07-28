using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader dr;

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(CIS.Presentation.UI.WindowsForms.Properties.Settings.Default.LocalDB);
            con.Open();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string a = frmViewUsers.tb.Text;

            if (txtPassConfirm.Text == txtPassword.Text)
            {

                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Logins SET password=@password WHERE username = '" + a + "' ;";

                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Password changed successfully");
                this.Close();

            }
            else
            {
                MessageBox.Show("Please confirm Password and Confirm Pasword fields match");
                txtPassword.Text = "";
                txtPassConfirm.Text = "";

            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
