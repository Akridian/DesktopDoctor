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
    public partial class EditPatientForm : Form
    {
        DesktopDoctorDatabaseEntities db = new DesktopDoctorDatabaseEntities();
        Patient patient;

        public EditPatientForm(Patient patient)
        {
            InitializeComponent();
            fenameTextBox.Text = patient.Fename;
            nameTextBox.Text = patient.Name;
            patronymicTextBox.Text = patient.Patronymic;
            if (patient.Birthdate.CompareTo(birthDateTimePicker.MinDate) < 0)
            {
                patient.Birthdate = birthDateTimePicker.MinDate;
            }
            birthDateTimePicker.Value = patient.Birthdate;
            snilsTextBox.Text = patient.SNILS;
            policyTextBox.Text = patient.Policy;
            this.patient = patient;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm
            {
                MdiParent = MdiParent
            };
            patientsForm.Show();
            patientsForm.Dock = DockStyle.Fill;
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            patient.Fename = fenameTextBox.Text.ToString();
            patient.Name = nameTextBox.Text.ToString();
            patient.Patronymic = patronymicTextBox.Text.ToString();
            patient.Birthdate = birthDateTimePicker.Value;
            patient.Gender = maleRadioButton.Checked;
            patient.SNILS = snilsTextBox.Text.ToString();
            patient.Policy = policyTextBox.Text.ToString();
            db.Patients.Add(patient);
            db.SaveChanges();
            PatientsForm patientsForm = new PatientsForm
            {
                MdiParent = MdiParent
            };
            patientsForm.Show();
            patientsForm.Dock = DockStyle.Fill;
            Close();
        }
    }
}
