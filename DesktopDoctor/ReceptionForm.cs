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
    public partial class ReceptionForm : Form
    {
        Reception reception;
        public List<Medicine> medicines;

        public ReceptionForm(MainForm mainForm, Reception reception)
        {
            InitializeComponent();
            MdiParent = mainForm;
            this.reception = reception;
            if (reception.Id == 0)
            {
                reception.Date = DateTime.Now.Date;
            }
            dateLabel.Text = reception.Date.ToShortDateString();
            doctorLabel.Text = reception.Employee.ToString();
            patientLabel.Text = reception.Patient.ToString();
            temperatureTextBox.Text = reception.Temperature.ToString();
            pressureTextBox.Text = reception.Pressure == null ? "" : reception.Pressure.ToString();
            diagnosisTextBox.Text = reception.Diagnosis == null ? "" : reception.Diagnosis.ToString();
            symptomsTextBox.Text = reception.Symptoms == null ? "" : reception.Symptoms.ToString();
            recommendationsTextBox.Text = reception.Recommendations == null ? "" : reception.Recommendations.ToString();
            medicines = new List<Medicine>();
            foreach (ReceptionMedicine recMed in reception.ReceptionsMedicines)
            {
                medicines.Add(recMed.Medicine);
            }
            medicineBindingSource.DataSource = medicines;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToPatientForm(reception.Patient);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(temperatureTextBox.Text.ToString(), out double temperature))
            {
                reception.Temperature = temperature;
            }
            else
            {
                reception.Temperature = null;
            }
            reception.Pressure = pressureTextBox.Text.ToString();
            reception.Diagnosis = diagnosisTextBox.Text.ToString();
            reception.Symptoms = symptomsTextBox.Text.ToString();
            reception.Recommendations = recommendationsTextBox.Text.ToString();
            if (reception.Id == 0)
            {
                (MdiParent as MainForm).db.Receptions.Add(reception);
            }
            else
            {
                (MdiParent as MainForm).db.Entry(reception).State = EntityState.Modified;
            }
            (MdiParent as MainForm).db.SaveChanges();
            List<Medicine> linkedMedicines = new List<Medicine>();
            List<ReceptionMedicine> linkedReceptionMedicines = reception.ReceptionsMedicines.ToList();
            foreach (ReceptionMedicine recMed in linkedReceptionMedicines)
            {
                if (!medicines.Contains(recMed.Medicine))
                {
                    (MdiParent as MainForm).db.ReceptionsMedicines.Remove(recMed);
                    (MdiParent as MainForm).db.SaveChanges();
                }
                else
                {
                    linkedMedicines.Add(recMed.Medicine);
                }
            }
            foreach (Medicine med in medicines)
            {
                if (!linkedMedicines.Contains(med))
                { 
                    ReceptionMedicine recMed = new ReceptionMedicine()
                    {
                        MedicineId = med.Id,
                        ReceptionId = reception.Id
                    };
                    (MdiParent as MainForm).db.ReceptionsMedicines.Add(recMed);
                    (MdiParent as MainForm).db.SaveChanges();
                }
            }
            (MdiParent as MainForm).GoToPatientForm(reception.Patient);
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            SelectMedicineForm selectMedicineForm = new SelectMedicineForm(this);
            selectMedicineForm.ShowDialog();
        }

        public void AddMedicine(Medicine medicine)
        {
            medicines.Add(medicine);
            medicineBindingSource.CurrencyManager.Refresh();
        }

        private void RemoveMedicineButton_Click(object sender, EventArgs e)
        {
            if (medicines.Count > 0)
            {
                Medicine medicine = medicineBindingSource.Current as Medicine;
                medicines.Remove(medicine);
                medicineBindingSource.CurrencyManager.Refresh();
            }
        }
    }
}
