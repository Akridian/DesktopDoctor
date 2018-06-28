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
    public partial class MedicineForm : Form
    {

        DesktopDoctorDatabaseEntities db = new DesktopDoctorDatabaseEntities();

        public MedicineForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ComeBack();
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(medicineNameTextBox.Text))
            {
                Medicine medicine = new Medicine()
                {
                    Name = medicineNameTextBox.Text,
                    Description = medicineDescriptionTextBox.Text
                };
                db.Medicines.Add(medicine);
                db.SaveChanges();
                MessageBox.Show("Новый препарат добавлен");
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
    }
}
