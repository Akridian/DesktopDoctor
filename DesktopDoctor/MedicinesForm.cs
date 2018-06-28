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
    public partial class MedicinesForm : Form
    {

        DesktopDoctorDatabaseEntities db = new DesktopDoctorDatabaseEntities();

        public MedicinesForm()
        {
            InitializeComponent();
        }

        private void MedicinesForm_Load(object sender, EventArgs e)
        {
            this.medicinesTableAdapter.Fill(this.desktopDoctorDatabaseDataSet.Medicines);

        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm
            {
                MdiParent = MdiParent
            };
            medicineForm.Show();
            Close();
        }
    }
}
