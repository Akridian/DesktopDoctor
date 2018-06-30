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
    public partial class MainForm : Form
    {
        public Account account;
        public DesktopDoctorDatabaseEntities db = new DesktopDoctorDatabaseEntities();

        public MainForm()
        {
            InitializeComponent();
            GoToAuthorizationForm();
        }

        public void Authorization(Account account)
        {
            this.account = account;
            if (account.SecurityLevel.Code == "doctor")
            {
                ToolStripMenuItem patientsToolStripMenuItem = new ToolStripMenuItem("Пациенты");
                topMenuStrip.Items.Add(patientsToolStripMenuItem);
                ToolStripDropDown patientsToolStripDropDown = new ToolStripDropDown();
                patientsToolStripMenuItem.DropDown = patientsToolStripDropDown;
                ToolStripMenuItem searchPatientsMenuItem = new ToolStripMenuItem("Поиск");
                searchPatientsMenuItem.Click += SearchPatientsMenuItem_Click;
                patientsToolStripDropDown.Items.Add(searchPatientsMenuItem);
                ToolStripMenuItem addPatientMenuItem = new ToolStripMenuItem("Добавить пациента");
                addPatientMenuItem.Click += AddPatientMenuItem_Click;
                patientsToolStripDropDown.Items.Add(addPatientMenuItem);
                GoToPatientsForm();
            }
            else if (account.SecurityLevel.Code == "admin")
            {
                ToolStripMenuItem medicinesToolStripMenuItem = new ToolStripMenuItem("Медикаменты");
                topMenuStrip.Items.Add(medicinesToolStripMenuItem);
                ToolStripDropDown medicinesToolStripDropDown = new ToolStripDropDown();
                medicinesToolStripMenuItem.DropDown = medicinesToolStripDropDown;
                ToolStripMenuItem searchMedicinesMenuItem = new ToolStripMenuItem("Поиск");
                searchMedicinesMenuItem.Click += SearchMedicinesMenuItem_Click;
                medicinesToolStripDropDown.Items.Add(searchMedicinesMenuItem);
                ToolStripMenuItem addMedicineMenuItem = new ToolStripMenuItem("Добавить медикамент");
                addMedicineMenuItem.Click += AddMedicineMenuItem_Click;
                medicinesToolStripDropDown.Items.Add(addMedicineMenuItem);
                GoToMedicinesForm();
            }
        }

        public void GoToPatientsForm()
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
            PatientsForm patientsForm = new PatientsForm(this);
            patientsForm.Show();
            patientsForm.Dock = DockStyle.Fill;
        }

        public void GoToMedicinesForm()
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
            MedicinesForm medicinesForm = new MedicinesForm(this);
            medicinesForm.Show();
            medicinesForm.Dock = DockStyle.Fill;
        }

        public void GoToEditPatientForm(Patient patient)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
            EditPatientForm editPatientForm = new EditPatientForm(this, patient);
            editPatientForm.Show();
            editPatientForm.Dock = DockStyle.Fill;
        }

        public void GoToEditMedicineForm(Medicine medicine)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
            EditMedicineForm medicineForm = new EditMedicineForm(this, medicine);
            medicineForm.Show();
            medicineForm.Dock = DockStyle.Fill;
        }

        public void GoToPatientForm(Patient patient)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
            PatientForm patientForm = new PatientForm(this, patient);
            patientForm.Show();
            patientForm.Dock = DockStyle.Fill;
        }

        public void GoToReceptionForm(Reception reception)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
            ReceptionForm receptionForm = new ReceptionForm(this, reception);
            receptionForm.Show();
            receptionForm.Dock = DockStyle.Fill;
        }

        public void GoToAuthorizationForm()
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
            AuthorizationForm authorizationForm = new AuthorizationForm(this);
            authorizationForm.Show();
            authorizationForm.Dock = DockStyle.Fill;
        }

        private void SearchPatientsMenuItem_Click(object sender, EventArgs e)
        {
            GoToPatientsForm();
        }

        private void AddPatientMenuItem_Click(object sender, EventArgs e)
        {
            GoToEditPatientForm(new Patient());
        }

        private void SearchMedicinesMenuItem_Click(object sender, EventArgs e)
        {
            GoToMedicinesForm();
        }

        private void AddMedicineMenuItem_Click(object sender, EventArgs e)
        {
            GoToEditMedicineForm(new Medicine());
        }
    }
}
