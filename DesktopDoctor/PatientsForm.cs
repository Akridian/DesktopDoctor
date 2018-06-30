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
        public PatientsForm(MainForm mainForm)
        {
            InitializeComponent();
            MdiParent = mainForm;
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            patientBindingSource.DataSource = (MdiParent as MainForm).db.Patients.ToList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string fename = fenameTextBox.Text.ToString();
            string name = nameTextBox.Text.ToString();
            string patronymic = patronymicTextBox.Text.ToString();
            string policy = policyTextBox.Text.ToString();
            patientBindingSource.DataSource = (MdiParent as MainForm).db.Patients.Where(pat => pat.Fename.StartsWith(fename) && pat.Name.StartsWith(name) && pat.Patronymic.StartsWith(patronymic) && pat.Policy.StartsWith(policy)).ToList();
        }

        private void PatientDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            (MdiParent as MainForm).GoToPatientForm(patientBindingSource.Current as Patient);
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToEditPatientForm(new Patient());
        }
    }
}
