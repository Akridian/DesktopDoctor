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

        public EditMedicineForm(Medicine medicine)
        {
            InitializeComponent();
            this.medicine = medicine;
            if(medicine != null)
            {
                addMedicineButton.Text = "Изменить";
            }
            else
            {
                addMedicineButton.Text = "Добавить";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ComeBack();
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            if (medicine == null)
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
                    MessageBox.Show("Новый препарат добавлен");
                    ComeBack();
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
                ComeBack();
            }
        }

        private void ComeBack()
        {
            MedicinesForm medicinesForm = new MedicinesForm
            {
                MdiParent = MdiParent
            };
            medicinesForm.Show();
            medicinesForm.Dock = DockStyle.Fill;
            Close();
        }

        private void EditMedicineForm_Load(object sender, EventArgs e)
        {
            if(medicine != null)
            {
                medicineNameTextBox.Text = medicine.Name;
                medicineDescriptionTextBox.Text = medicine.Description;
            }
        }
    }
}
