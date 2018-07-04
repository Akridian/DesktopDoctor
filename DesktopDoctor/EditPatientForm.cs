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
        Patient patient;

        public EditPatientForm(MainForm mainForm, Patient patient)
        {
            InitializeComponent();
            MdiParent = mainForm;
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
            if (patient.Id != 0 && !patient.Gender)
            {
                femaleRadioButton.Checked = true;
            }
            this.patient = patient;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (patient.Id == 0)
            {
                (MdiParent as MainForm).GoToPatientsForm();
            }
            else
            {
                (MdiParent as MainForm).GoToPatientForm(patient);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (fenameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите фамилию пациента.");
                return;
            }
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите имя пациента.");
                return;
            }
            if (snilsTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите СНИЛС пациента.");
                return;
            }
            if (policyTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите номер полиса пациента.");
                return;
            }
            patient.Fename = fenameTextBox.Text.ToString();
            patient.Name = nameTextBox.Text.ToString();
            patient.Patronymic = patronymicTextBox.Text.ToString();
            patient.Birthdate = birthDateTimePicker.Value;
            patient.Gender = maleRadioButton.Checked;
            patient.SNILS = snilsTextBox.Text.ToString();
            patient.Policy = policyTextBox.Text.ToString();
            if (patient.Id == 0)
            {
                (MdiParent as MainForm).db.Patients.Add(patient);
            }
            else
            {
                (MdiParent as MainForm).db.Entry(patient).State = EntityState.Modified;
            }
            (MdiParent as MainForm).db.SaveChanges();
            (MdiParent as MainForm).GoToPatientForm(patient);
        }
    }
}
