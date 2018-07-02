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
            (MdiParent as MainForm).GoToPatientForm(reception.Patient);
        }
    }
}
