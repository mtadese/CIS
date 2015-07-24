---
title: "view_patient_record"
author: "Micheal"
date: "Wednesday, April 22, 2015"
output: html_document
---


## View Patient Record (Demographics)

###//system references
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
###//references for connecting to MySql database
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;



namespace HIS_Manager
{
    public partial class frmPatientRecord : Form
    {
        public frmPatientRecord()
        {
            InitializeComponent();
        }
###        //declaration of variables to be used within the program
        string connectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adap;
        DataSet ds;
        MySqlDataReader dr;


###            //connecting string for the C# application to MySql database
        private void frmPatientRecord_Load(object sender, EventArgs e)
        {
            txtPatImage.Visible = false;

            connectionString = "Server=127.0.0.1;Database=his_record;Uid=root;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();

            Load_PatientRecord();                      
            Load_ClinicsRecord();
        }
        
###            //importing data from the MySql database into the patient record form
        private void Load_PatientRecord()
        {
            string a = frmSearchPat.pid.Text;

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Patients where Patient_ID = '" + a + "' ";
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                txtPid.Text = Convert.ToString(dr[0]);
                txtHospNum.Text = Convert.ToString(dr[1]);
                cmbtitle.Text = Convert.ToString(dr[2]);
                txtLname.Text = Convert.ToString(dr[3]);
                txtFname.Text = Convert.ToString(dr[4]);
                txtMname.Text = Convert.ToString(dr[5]);
                cmbGender.Text = Convert.ToString(dr[6]);
                txtDob.Text = Convert.ToString(dr[7]);
                cmbMStatus.Text = Convert.ToString(dr[14]);
                txtPatConsultant.Text = Convert.ToString(dr[15]);
                txtMPhone.Text = Convert.ToString(dr[9]);
                txtPhone.Text = Convert.ToString(dr[8]);
                txtEmail.Text = Convert.ToString(dr[10]);
                txtHAddress.Text = Convert.ToString(dr[11]);
                txtCity.Text = Convert.ToString(dr[12]);
                txtState.Text = Convert.ToString(dr[13]);
                txtOAddress.Text = Convert.ToString(dr[22]);
                txtNat.Text = Convert.ToString(dr[16]);
                txtSOrigin.Text = Convert.ToString(dr[17]);
                txtTOrigin.Text = Convert.ToString(dr[18]);
                txtPoB.Text = Convert.ToString(dr[19]);
                txtReligion.Text = Convert.ToString(dr[20]);
                txtOccupation.Text = Convert.ToString(dr[21]);
                cmbNIDType.Text = Convert.ToString(dr[24]);
                txtNidNumber.Text = Convert.ToString(dr[25]);
                txtNok.Text = Convert.ToString(dr[26]);
                txtNoKAddress.Text = Convert.ToString(dr[27]);
                txtNoKPhone.Text = Convert.ToString(dr[28]);
                txtNoKEmail.Text = Convert.ToString(dr[29]);
                cmbNokRelationship.Text = Convert.ToString(dr[30]);
                txtFather.Text = Convert.ToString(dr[31]);
                txtMother.Text = Convert.ToString(dr[32]);
                txtHealthIns.Text = Convert.ToString(dr[33]);
                txtHealthAddr.Text = Convert.ToString(dr[34]);
                txtHealthPhone.Text = Convert.ToString(dr[35]);
                txtHealthEmail.Text = Convert.ToString(dr[36]);
                
                dr.Close();
            }
            loadImage();
        }
                      
###            //updating database records with new updates made on form
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"); 

            try
            {
                if (txtMPhone.Text == "")
                {
                    txtMPhone.Text = "0";
                }
                else if (txtNoKPhone.Text == "")
                {
                    txtNoKPhone.Text = "0";
                }
                else if (txtHealthPhone.Text == "")
                {
                    txtHealthPhone.Text = "0";
                }

                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Patients SET hospitalnumber=@hospitalnumber, title=@title, lname=@lname, fname=@fname, mname=@mname, gender=@gender, DateofBirth=@DateofBirth, Phone=@Phone, Mobile_Phone=@Mobile_Phone, Email=@Email, HomeAddress=@HomeAddress, City=@City, State=@State, MaritalStatus=@MaritalStatus, Patient_Consultant=@PatConsultant, Nationality=@Nationality, State_of_Origin=@State_of_Origin, Hometown=@Hometown, Place_of_Birth=@Place_of_Birth, Religion=@Religion, Occupation=@Occupation, OfficeAddress=@OfficeAddress, National_ID_Type=@National_ID_Type, National_ID_Number=@National_ID_Number, Next_of_Kin=@Next_of_Kin, Address_NOK=@Address_NOK, Phone_NOK=@Phone_NOK, Email_NOK=@Email_NOK, NOK_Relationship=@NOK_Relationship, Name_of_Father=@Name_of_Father, Name_of_Mother=@Name_of_Mother, Health_Insurance_Prov=@Health_Insurance_Prov, Address_HIP=@Address_HIP, Phone_HIP=@Phone_HIP, Email_HIP=@Email_HIP, Date_Amended=@Date_Amended WHERE Patient_ID= '" + txtPid.Text + "' ;";
                              
                    cmd.Parameters.AddWithValue("@hospitalnumber", txtHospNum.Text);
                    cmd.Parameters.AddWithValue("@title", cmbtitle.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                    cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                    cmd.Parameters.AddWithValue("@mname", txtMname.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);                    
                    cmd.Parameters.AddWithValue("@DateofBirth", DateTime.Parse(txtDob.Text));
                    cmd.Parameters.AddWithValue("@Phone", int.Parse(txtPhone.Text));
                    cmd.Parameters.AddWithValue("@Mobile_Phone", int.Parse(txtMPhone.Text));
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@HomeAddress", txtHAddress.Text);
                    cmd.Parameters.AddWithValue("@city", txtCity.Text);
                    cmd.Parameters.AddWithValue("@State", txtState.Text);
                    cmd.Parameters.AddWithValue("@MaritalStatus", cmbMStatus.Text);
                    cmd.Parameters.AddWithValue("@PatConsultant", txtPatConsultant.Text);
                    cmd.Parameters.AddWithValue("@Nationality", txtNat.Text);
                    cmd.Parameters.AddWithValue("@State_of_origin", txtSOrigin.Text);
                    cmd.Parameters.AddWithValue("@Hometown", txtTOrigin.Text);
                    cmd.Parameters.AddWithValue("@Place_of_Birth", txtPoB.Text);
                    cmd.Parameters.AddWithValue("@Religion", txtReligion.Text);
                    cmd.Parameters.AddWithValue("@Occupation", txtOccupation.Text);
                    cmd.Parameters.AddWithValue("@OfficeAddress", txtOAddress.Text);
                    cmd.Parameters.AddWithValue("@National_ID_Type", cmbNIDType.Text);
                    cmd.Parameters.AddWithValue("@National_ID_Number", txtNidNumber.Text);
                    cmd.Parameters.AddWithValue("@Next_of_Kin", txtNok.Text);
                    cmd.Parameters.AddWithValue("@Address_NOK", txtNoKAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone_NOK", int.Parse(txtNoKPhone.Text));
                    cmd.Parameters.AddWithValue("@Email_NOK", txtNoKEmail.Text);
                    cmd.Parameters.AddWithValue("@NOK_Relationship", cmbNokRelationship.Text);
                    cmd.Parameters.AddWithValue("@Name_of_Father", txtFather.Text);
                    cmd.Parameters.AddWithValue("@Name_of_Mother", txtMother.Text);
                    cmd.Parameters.AddWithValue("@Health_Insurance_Prov", txtHealthIns.Text);
                    cmd.Parameters.AddWithValue("@Address_HIP", txtHealthAddr.Text);
                    cmd.Parameters.AddWithValue("@Phone_HIP", int.Parse(txtHealthPhone.Text));
                    cmd.Parameters.AddWithValue("@Email_HIP", txtHealthEmail.Text);
                    cmd.Parameters.AddWithValue("@Date_Amended", txtDateAmend.Text);
                
                    cmd.ExecuteNonQuery();

                    saveImage();
                
                        MessageBox.Show("Patient Record Updated");                   
                }
                        
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message, "Update Patient Record"); 
            }

        }

###            //delete patient record - This code is not activated within the application
        private void record_delete()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Patients " + "WHERE Patient_ID= '" + txtPid.Text + "' ;";

            cmd.ExecuteNonQuery();

            MessageBox.Show("Patient Record Deleted");
        }

###            //load patient's picture from the system
        private void button3_Click(object sender, EventArgs e)
        {
            string picFile = "";
            OpenFD.InitialDirectory = "C:";
            OpenFD.Title = "Load Patient Picture";
            OpenFD.Filter = "Jpeg Files|*.jpg|GIF Images|*.gif";
            OpenFD.FileName = "";

            if (OpenFD.ShowDialog() == DialogResult.OK)
            {
                picFile = OpenFD.FileName;
                txtPatImage.Text = picFile;
                picPatImage.Image = Image.FromFile(picFile);
            }
        }


###                //save patient's picture into database
        private void saveImage()
        {
            try
            {
                FileStream fs;
                BinaryReader br;

                if (txtPid.Text.Length > 0 && txtPatImage.Text.Length > 0)
                {
                    string fileName = txtPatImage.Text;
                    byte[] imageData;
                    fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    br = new BinaryReader(fs);
                    imageData = br.ReadBytes((int)fs.Length);

                    br.Close();
                    fs.Close();


                    cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE Patients SET patientImage=@patientImage WHERE Patient_ID= '" + txtPid.Text + "' ;";
                    cmd.Parameters.AddWithValue("@patientImage", imageData);

                    //con.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        //MessageBox.Show("Image saved successfully");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Patient Image");
            }
        }




###                //import patient's picture from database to form's picture control
        private void loadImage()
        {
            try
            {
                cmd = new MySqlCommand("Select patientImage from Patients where Patient_ID ='" + txtPid.Text + "' ;", con);
                adap = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                adap.Fill(ds, "Patients");
                int c = ds.Tables["Patients"].Rows.Count;

                if (c > 0)
                {
                    Byte[] byteBlobData = new Byte[0];
                    byteBlobData = (Byte[])(ds.Tables["Patients"].Rows[c - 1]["patientImage"]);

                    MemoryStream stm = new MemoryStream(byteBlobData);
                    picPatImage.Image = Image.FromStream(stm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Patient Image");
            }
        }

###            //close this module
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

###            //load patient's demographics on a textbox control for hardcopy printing
        private void LoadReport()
        {
            richTextBox1.Text = "Patient Record: " + Environment.NewLine + Environment.NewLine + label1.Text + ": " + txtPid.Text + Environment.NewLine + label2.Text + ": " + txtHospNum.Text + Environment.NewLine + label31.Text + ": " + cmbtitle.Text + Environment.NewLine + label3.Text + ": " + txtLname.Text + Environment.NewLine + label4.Text + ": " + txtFname.Text + Environment.NewLine + "Middle Name" + ": " + txtMname.Text + Environment.NewLine + "Gender" + ": " + cmbGender.Text + Environment.NewLine + "Date of Birth" + ": " + txtDob.Text + Environment.NewLine + "Phone" + ": " + txtPhone.Text + Environment.NewLine + "Mobile Phone" + ": " + txtMPhone.Text + Environment.NewLine + "Email" + ": " + txtEmail.Text + Environment.NewLine + "Home Address" + ": " + txtHAddress.Text + Environment.NewLine + "City" + ": " + txtCity.Text + Environment.NewLine + "State" + ": " + txtState.Text + Environment.NewLine + "Marital Status" + ": " + cmbMStatus.Text + Environment.NewLine + "Nationality" + ": " + txtNat.Text + Environment.NewLine + "State of Origin" + ": " + txtSOrigin.Text + Environment.NewLine + "Town of Origin" + ": " + txtTOrigin.Text + Environment.NewLine + "Place of Birth" + ": " + txtPoB.Text + Environment.NewLine + "Religion" + ": " + txtReligion.Text + Environment.NewLine + "Occupation" + ": " + txtOccupation.Text + Environment.NewLine + "Office Address" + ": " + txtOAddress.Text + Environment.NewLine + "National ID Type" + ": " + cmbNIDType.Text + Environment.NewLine + "National ID Number" + ": " + txtNidNumber.Text + Environment.NewLine + "Next of Kin" + ": " + txtNok.Text + Environment.NewLine + "Address" + ": " + txtNoKAddress.Text + Environment.NewLine + "Phone" + ": " + txtNoKPhone.Text + Environment.NewLine + "Email" + ": " + txtNoKEmail.Text + Environment.NewLine + "Relationship" + ": " + cmbNokRelationship.Text;
        }

###            // print patient's demographic on hardcopy 
        private void btnPrint_Click(object sender, EventArgs e)
        {
###            // calling the load Report code block before printing on hardcopy
            LoadReport();
            
            PrintDialog print = new PrintDialog();

            System.Drawing.Printing.PrintDocument printDoc = new System.Drawing.Printing.PrintDocument();
            print.AllowSomePages = true;
            print.ShowHelp = true;
            printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDoc_PrintPage);
            print.Document = printDoc;

            if (print.ShowDialog(this) == DialogResult.OK)
            {
                printDoc.Print();
            } 
        }

###            //set printing section properties
        private void printDoc_PrintPage(Object Sender, System.Drawing.Printing.PrintPageEventArgs e)
        {            
            string strPrint = richTextBox1.Text ;
            int charCount = 0;
            int lineCount = 0;

            e.Graphics.MeasureString(strPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charCount, out lineCount);
            e.Graphics.DrawString(strPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
            strPrint = strPrint.Substring(charCount);
            if (strPrint.Length > 0)
            {
                //e.HasMorePages = true;
                e.Graphics.DrawString(strPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
                
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDob.Text = Convert.ToString(dateTimePicker1.Value.AddDays(0).ToString("yyyy/MM/dd"));
        }



###            //search patient's preferred clinician to load into patient's demographics
        private void Load_ClinicsRecord()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select lastname, title from Clinicians";
            adap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds, "clinicians");
            dgridClinics.DataSource = ds.Tables[0];
            dgridClinics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

###            //load preferred clinician into patient's demographics
        private void btnLoadClinic_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgridClinics.SelectedRows[0];
                txtPatConsultant.Text = dr.Cells[1].Value.ToString() + " " + dr.Cells[0].Value.ToString();
                grpClinics.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Clinics");
            }

        }

###            // display list of clinicians to select from
        private void btnSearchClinic_Click(object sender, EventArgs e)
        {
            grpClinics.Visible = true;
            grpClinics.Left = 420;;
            grpClinics.Top = 0;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpClinics.Visible = false;

        }

###            //displayed list of clinicians to select as the patient's preffered 
        private void dgridClinics_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgridClinics.SelectedRows[0];
                txtPatConsultant.Text = dr.Cells[1].Value.ToString() + " " + dr.Cells[0].Value.ToString();
                grpClinics.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Clinics");
            }
        }

    }
}