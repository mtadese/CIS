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
    public partial class frmSearchPat : Form
    {
        public frmSearchPat()
        {
            InitializeComponent();
        }
        //declaration of variables to be used within the program
            string connectionString;
            MySqlDataReader dr;

            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataAdapter adap;
            DataSet ds1, ds;

            public static TextBox pid;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //connecting string for the C# application to MySql database
            this.Height = 155;
            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();

           pid = txtpid2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search for patient with available criteria (id, names, hospital number)
            if (txtPid.Text == "" && txtLname.Text == "" && txtFname.Text == "" && txtHospNum.Text == "")
            {
                MessageBox.Show("No Patient Found");
            }

            else if (txtLname.Text == "" )
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Patients where fName= '" + txtFname.Text + "' or Patient_ID = '" + txtPid.Text + "' or HospitalNumber = '" + txtHospNum.Text + "'  ";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "patients");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                this.Height = 320;
            }


            else
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Patients where lName like '" + txtLname.Text + "%" + "' or fName= '" + txtFname.Text + "' or Patient_ID = '" + txtPid.Text + "' or HospitalNumber = '" + txtHospNum.Text + "' ";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "patients");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                txtLname.Clear();

                this.Height = 320;
            }


            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            //load demographics of highlighted patient
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtpid2.Text = dr.Cells[0].Value.ToString();
            textBox2.Text = dr.Cells[1].Value.ToString();
            frmPatientRecord patrecord = new frmPatientRecord();
            patrecord.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Height = 155;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //additional option to select highlighted patient by double-clicking the preferred patient to view
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtpid2.Text = dr.Cells[0].Value.ToString();
            textBox2.Text = dr.Cells[1].Value.ToString();
            frmPatientRecord patrecord = new frmPatientRecord();
            patrecord.Show();

        }

           
        



    }
}
