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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ComeBack();
        }

        private void btnAddNewMedicine_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbxNameMedicine.Text))
            {
                Medicine medicine = new Medicine()
                {
                    Name = tbxNameMedicine.Text,
                    Description = tbxDescriptionMedicine.Text
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
            Close();
        }
    }
}
