using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDoctor
{
    public partial class PatientsForm : Form
    {
        private DesktopDoctorDatabaseEntities db = new DesktopDoctorDatabaseEntities();

        public PatientsForm()
        {
            InitializeComponent();
            patientBindingSource.DataSource = db.Patients.ToList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string fename = fenameTextBox.Text.ToString();
            string name = nameTextBox.Text.ToString();
            string patronymic = patronymicTextBox.Text.ToString();
            string policy = policyTextBox.Text.ToString();
            patientBindingSource.DataSource = db.Patients.Where(pat => pat.Fename.StartsWith(fename) && pat.Name.StartsWith(name) && pat.Patronymic.StartsWith(patronymic) && pat.Policy.StartsWith(policy)).ToList();
        }

        private void PatientDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PatientForm patientForm = new PatientForm(patientBindingSource.Current as Patient)
            {
                MdiParent = MdiParent
            };
            patientForm.Show();
            patientForm.Dock = DockStyle.Fill;
            Close();

        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            EditPatientForm editPatientForm = new EditPatientForm(new Patient())
            {
                MdiParent = MdiParent
            };
            editPatientForm.Show();
            editPatientForm.Dock = DockStyle.Fill;
            Close();
        }
    }
}
