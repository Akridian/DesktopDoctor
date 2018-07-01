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
    public partial class PatientForm : Form
    {
        Patient patient;

        public PatientForm(MainForm mainForm, Patient patient)
        {
            InitializeComponent();
            MdiParent = mainForm;
            fenameLabel.Text = patient.Fename;
            nameLabel.Text = patient.Name;
            patronymicLabel.Text = patient.Patronymic;
            genderLabel.Text = "Пол: " + (patient.Gender ? "Мужской" : "Женский");
            birthdateLabel.Text = "Дата рождения: " + patient.Birthdate.ToShortDateString();
            snilsLabel.Text = "СНИЛС: " + patient.SNILS;
            policyLabel.Text = "Полис: " + patient.Policy;
            this.patient = patient;
            receptionBindingSource.DataSource = patient.Receptions.OrderByDescending(r => r.Date).ToList();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToPatientsForm();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToEditPatientForm(patient);
        }

        private void StartReceptionButton_Click(object sender, EventArgs e)
        {
            Reception reception = new Reception
            {
                Patient = patient,
                Employee = (MdiParent as MainForm).account.Employee
            };
            (MdiParent as MainForm).GoToReceptionForm(reception);
        }

        private void ReceptionDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            (MdiParent as MainForm).GoToReceptionForm(receptionBindingSource.Current as Reception);
        }
    }
}
