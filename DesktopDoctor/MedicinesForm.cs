﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace DesktopDoctor
{
    public partial class MedicinesForm : Form
    {
        public MedicinesForm(MainForm mainForm)
        {
            InitializeComponent();
            MdiParent = mainForm;
        }

        private void MedicinesForm_Load(object sender, EventArgs e)
        {
            medicinesBindingSource.DataSource = ((MdiParent as MainForm).db.Medicines.Where(m => m.IsDeleted == false)).ToList();
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToEditMedicineForm(new Medicine());
        }

        private void ChangeMedicineButton_Click(object sender, EventArgs e)
        {
            if (medicinesBindingSource.Current is Medicine medicine)
            {
                (MdiParent as MainForm).GoToEditMedicineForm(medicine);
            }
        }

        private void RemoveMedicineButton_Click(object sender, EventArgs e)
        {
            if (medicinesBindingSource.Current is Medicine medicine)
            {
                if (MessageBox.Show("Удалить " + medicine.Name + " ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    medicine.IsDeleted = true;
                    (MdiParent as MainForm).db.SaveChanges();
                    medicinesBindingSource.DataSource = ((MdiParent as MainForm).db.Medicines.Where(m => m.IsDeleted == false)).ToList();
                }
                else
                {
                    return;
                }
            }
        }

        private void ToDoctorsButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToEmployeesForm();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string name = searchNameMedicineTextBox.Text;
            string description = searchDescriptionMedicineTextBox.Text;
            medicinesBindingSource.DataSource = (MdiParent as MainForm).db.Medicines.Where(m => m.Name.StartsWith(name) && m.Description.StartsWith(description) && m.IsDeleted == false).ToList();
        }
    }
}
