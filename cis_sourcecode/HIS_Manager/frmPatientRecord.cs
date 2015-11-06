using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CIS.Application.Entities;
using CIS.Data.DataAccess;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmPatientRecord : Form
    {
        private DataGridViewRow _patientSelected;

        public frmPatientRecord()
        {
            InitializeComponent();
        }

        public frmPatientRecord(DataGridViewRow patient)
            : this()
        {
            _patientSelected = patient;
        }

        private void frmPatientRecord_Load(object sender, EventArgs e)
        {
            txtPatImage.Visible = false;

            Load_PatientRecord();
            Load_ClinicsRecord();
        }

        private void Load_PatientRecord()
        {
            txtPid.Text = Convert.ToString(_patientSelected.Cells[0]);
            txtHospNum.Text = Convert.ToString(_patientSelected.Cells[1]);
            cmbtitle.Text = Convert.ToString(_patientSelected.Cells[2]);
            txtLname.Text = Convert.ToString(_patientSelected.Cells[3]);
            txtFname.Text = Convert.ToString(_patientSelected.Cells[4]);
            txtMname.Text = Convert.ToString(_patientSelected.Cells[5]);
            cmbGender.Text = Convert.ToString(_patientSelected.Cells[6]);
            txtDob.Text = Convert.ToString(_patientSelected.Cells[7]);
            cmbMStatus.Text = Convert.ToString(_patientSelected.Cells[14]);
            txtPatConsultant.Text = Convert.ToString(_patientSelected.Cells[15]);
            txtMPhone.Text = Convert.ToString(_patientSelected.Cells[9]);
            txtPhone.Text = Convert.ToString(_patientSelected.Cells[8]);
            txtEmail.Text = Convert.ToString(_patientSelected.Cells[10]);
            txtHAddress.Text = Convert.ToString(_patientSelected.Cells[11]);
            txtCity.Text = Convert.ToString(_patientSelected.Cells[12]);
            txtState.Text = Convert.ToString(_patientSelected.Cells[13]);
            txtOAddress.Text = Convert.ToString(_patientSelected.Cells[22]);
            txtNat.Text = Convert.ToString(_patientSelected.Cells[16]);
            txtSOrigin.Text = Convert.ToString(_patientSelected.Cells[17]);
            txtTOrigin.Text = Convert.ToString(_patientSelected.Cells[18]);
            txtPoB.Text = Convert.ToString(_patientSelected.Cells[19]);
            txtReligion.Text = Convert.ToString(_patientSelected.Cells[20]);
            txtOccupation.Text = Convert.ToString(_patientSelected.Cells[21]);
            cmbNIDType.Text = Convert.ToString(_patientSelected.Cells[24]);
            txtNidNumber.Text = Convert.ToString(_patientSelected.Cells[25]);
            txtNok.Text = Convert.ToString(_patientSelected.Cells[26]);
            txtNoKAddress.Text = Convert.ToString(_patientSelected.Cells[27]);
            txtNoKPhone.Text = Convert.ToString(_patientSelected.Cells[28]);
            txtNoKEmail.Text = Convert.ToString(_patientSelected.Cells[29]);
            cmbNokRelationship.Text = Convert.ToString(_patientSelected.Cells[30]);
            txtFather.Text = Convert.ToString(_patientSelected.Cells[31]);
            txtMother.Text = Convert.ToString(_patientSelected.Cells[32]);
            txtHealthIns.Text = Convert.ToString(_patientSelected.Cells[33]);
            txtHealthAddr.Text = Convert.ToString(_patientSelected.Cells[34]);
            txtHealthPhone.Text = Convert.ToString(_patientSelected.Cells[35]);
            txtHealthEmail.Text = Convert.ToString(_patientSelected.Cells[36]);
            picPatImage.Image = LoadImage(Encoding.Default.GetBytes(_patientSelected.Cells[37].ToString()));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            var patient = new Patient()
            {
                Identifier = int.Parse(txtPid.Text),
                HospitalNumber = int.Parse(txtHospNum.Text),
                Title = (Title)Enum.Parse(typeof(Title), cmbtitle.Text),
                LastName = txtLname.Text,
                FirstName = txtFname.Text,
                MiddleName = txtMname.Text,
                Gender = (Gender)Enum.Parse(typeof(Gender), cmbGender.Text),
                BirthDate = DateTime.Parse(txtDob.Text),
                Phone = int.Parse(txtPhone.Text),
                MobilePhone = int.Parse(txtMPhone.Text),
                Email = txtEmail.Text,
                HomeAddress = txtHAddress.Text,
                City = txtCity.Text,
                State = txtState.Text,
                MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), cmbMStatus.Text),
                PatientConsultant = txtPatConsultant.Text,
                Nationality = txtNat.Text,
                StateOfOrigin = txtSOrigin.Text,
                Hometown = txtTOrigin.Text,
                PlaceOfBirth = txtPoB.Text,
                Religion = txtReligion.Text,
                Occupation = txtOccupation.Text,
                OfficeAddress = txtOAddress.Text,
                NationalIdType = cmbNIDType.Text,
                NationalIdNumber = txtNidNumber.Text,
                NextOfKin = txtNok.Text,
                AddressNextOfKin = txtNoKAddress.Text,
                PhoneNextOfKin = int.Parse(txtNoKPhone.Text),
                EmailNextOfKin = txtNoKEmail.Text,
                NextOfKinRelationship = cmbNokRelationship.Text,
                NameOfFather = txtFather.Text,
                NameOfMother = txtMother.Text,
                HealthInsuranceProvider = txtHealthIns.Text,
                AddressHealthInsuranceProvider = txtHealthAddr.Text,
                PhoneHealthInsuranceProvider = int.Parse(txtHealthPhone.Text),
                EmailHealthInsuranceProvider = txtHealthEmail.Text,
                DateAmended = txtDateAmend.Text,
                Photo = GetBytesFromImage()
            };

            using (ClinicModel context = new ClinicModel())
            {
                context.Patients.Add(patient);

                context.SaveChanges();
            }

            GetBytesFromImage();

            MessageBox.Show("Patient Record Updated");
        }

        private void record_delete()
        {
            using (ClinicModel context = new ClinicModel())
            {
                context.Patients.Remove(new Patient() { Identifier = int.Parse(txtPid.Text) });
            }

            MessageBox.Show("Patient Record Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //load patient's picture from the system
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

        private byte[] GetBytesFromImage()
        {
            byte[] imageData;

            using (var file = new FileStream(txtPatImage.Text, FileMode.Open, FileAccess.Read))
            {
                using (var bin = new BinaryReader(file))
                {
                    imageData = bin.ReadBytes((int)file.Length);
                }
            }

            return imageData;
        }

        private Image LoadImage(byte[] photo)
        {
            MemoryStream stm = new MemoryStream(photo);
            return Image.FromStream(stm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close this module
            this.Close();

        }

        private void LoadReport()
        {
            //load patient's demographics on a textbox control for hardcopy printing
            richTextBox1.Text = "Patient Record: " + Environment.NewLine + Environment.NewLine + label1.Text + ": " + txtPid.Text + Environment.NewLine + label2.Text + ": " + txtHospNum.Text + Environment.NewLine + label31.Text + ": " + cmbtitle.Text + Environment.NewLine + label3.Text + ": " + txtLname.Text + Environment.NewLine + label4.Text + ": " + txtFname.Text + Environment.NewLine + "Middle Name" + ": " + txtMname.Text + Environment.NewLine + "Gender" + ": " + cmbGender.Text + Environment.NewLine + "Date of Birth" + ": " + txtDob.Text + Environment.NewLine + "Phone" + ": " + txtPhone.Text + Environment.NewLine + "Mobile Phone" + ": " + txtMPhone.Text + Environment.NewLine + "Email" + ": " + txtEmail.Text + Environment.NewLine + "Home Address" + ": " + txtHAddress.Text + Environment.NewLine + "City" + ": " + txtCity.Text + Environment.NewLine + "State" + ": " + txtState.Text + Environment.NewLine + "Marital Status" + ": " + cmbMStatus.Text + Environment.NewLine + "Nationality" + ": " + txtNat.Text + Environment.NewLine + "State of Origin" + ": " + txtSOrigin.Text + Environment.NewLine + "Town of Origin" + ": " + txtTOrigin.Text + Environment.NewLine + "Place of Birth" + ": " + txtPoB.Text + Environment.NewLine + "Religion" + ": " + txtReligion.Text + Environment.NewLine + "Occupation" + ": " + txtOccupation.Text + Environment.NewLine + "Office Address" + ": " + txtOAddress.Text + Environment.NewLine + "National ID Type" + ": " + cmbNIDType.Text + Environment.NewLine + "National ID Number" + ": " + txtNidNumber.Text + Environment.NewLine + "Next of Kin" + ": " + txtNok.Text + Environment.NewLine + "Address" + ": " + txtNoKAddress.Text + Environment.NewLine + "Phone" + ": " + txtNoKPhone.Text + Environment.NewLine + "Email" + ": " + txtNoKEmail.Text + Environment.NewLine + "Relationship" + ": " + cmbNokRelationship.Text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // calling the lodReport code block before printing on hardcopy
            LoadReport();

            // print patient's demographic on hardcopy 
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

        private void printDoc_PrintPage(Object Sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //set printing section properties
            string strPrint = richTextBox1.Text;
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

        private void Load_ClinicsRecord()
        {
            List<Clinic> clinics = new List<Clinic>();

            using (ClinicModel context = new ClinicModel())
            {
                clinics = context.Clinicians.ToList();
            }

            dgridClinics.DataSource = clinics;
        }

        private void btnLoadClinic_Click(object sender, EventArgs e)
        {
            //load preferred clinician into patient's demographics
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

        private void btnSearchClinic_Click(object sender, EventArgs e)
        {
            // display list of clinicians to select from
            grpClinics.Visible = true;
            grpClinics.Left = 420; ;
            grpClinics.Top = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpClinics.Visible = false;

        }

        private void dgridClinics_DoubleClick(object sender, EventArgs e)
        {
            //displayed list of clinicians to select as the patient's preffered 
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