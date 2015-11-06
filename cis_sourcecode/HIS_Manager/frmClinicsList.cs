using CIS.Application.Entities;
using CIS.Data.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    public partial class frmClinicsList : Form
    {
        public frmClinicsList()
        {
            InitializeComponent();
        }

        private void frmClinicsList_Load(object sender, EventArgs e)
        {
            using (ClinicModel context = new ClinicModel())
            {
                var clinicians = context.Clinicians.ToList();
                dgvClinicians.DataSource = clinicians;
            }
        }

        private void btnNewC_Click(object sender, EventArgs e)
        {
            frmNewClinic frm = new frmNewClinic();
            frm.ShowDialog();
        }

        private void btnEditC_Click(object sender, EventArgs e)
        {
            if (dgvClinicians.SelectedColumns.Count > 0)
            {
                object id = dgvClinicians.SelectedRows[0].Cells[0].Value;
                Clinic clinic;

                using (ClinicModel context = new ClinicModel())
                {
                    clinic = context.Clinicians
                        .Where(x => x.Identifier.Equals(id))
                        .Single();
                }

                frmEditClinic frm = new frmEditClinic(clinic);
                frm.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBookAppt_Click(object sender, EventArgs e)
        {
            frmBookAppointment frm = new frmBookAppointment();
            frm.ShowDialog();
        }
    }
}
