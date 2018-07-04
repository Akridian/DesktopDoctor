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
    public partial class EditMedicineForm : Form
    {
        Medicine medicine;

        public EditMedicineForm(MainForm mainForm, Medicine medicine)
        {
            InitializeComponent();
            MdiParent = mainForm;
            this.medicine = medicine;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToMedicinesForm();
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            if (medicine.Id == 0)
            {
                if (!string.IsNullOrWhiteSpace(medicineNameTextBox.Text))
                {
                    Medicine medicine = new Medicine()
                    {
                        Name = medicineNameTextBox.Text,
                        Description = medicineDescriptionTextBox.Text
                    };
                    (MdiParent as MainForm).db.Medicines.Add(medicine);
                    (MdiParent as MainForm).db.SaveChanges();
                    (MdiParent as MainForm).GoToMedicinesForm();
                }
                else
                {
                    MessageBox.Show("Необходимо заполнить поля");
                }
            }
            else
            {
                Medicine m = (MdiParent as MainForm).db.Medicines.Find(medicine.Id);

                m.Name = medicineNameTextBox.Text;
                m.Description = medicineDescriptionTextBox.Text;

                (MdiParent as MainForm).db.SaveChanges();
                MessageBox.Show("Препарат изменен");
                (MdiParent as MainForm).GoToMedicinesForm();
            }
        }

        private void EditMedicineForm_Load(object sender, EventArgs e)
        {
            if(medicine.Id != 0)
            {
                medicineNameTextBox.Text = medicine.Name;
                medicineDescriptionTextBox.Text = medicine.Description;
            }
        }
    }
}
