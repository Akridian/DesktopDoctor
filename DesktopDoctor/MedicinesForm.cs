using System;
using System.Linq;
using System.Windows.Forms;

namespace DesktopDoctor
{
    public partial class MedicinesForm : Form
    {

        DesktopDoctorDatabaseEntities db = new DesktopDoctorDatabaseEntities();

        public MedicinesForm()
        {
            InitializeComponent();
            medicinesBindingSource.DataSource = db.Medicines.ToList();
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            EditMedicineForm medicineForm = new EditMedicineForm(null)
            {
                MdiParent = MdiParent
            };
            medicineForm.Show();
            medicineForm.Dock = DockStyle.Fill;
            Close();
        }

        private void changeMedicineButton_Click(object sender, EventArgs e)
        {
            if(medicinesDataGridView.SelectedRows.Count >0)
            {
                int index = medicinesDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(medicinesDataGridView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                Medicine medicine = db.Medicines.Find(id);

                if(medicine != null)
                {
                    EditMedicineForm medicineForm = new EditMedicineForm(medicine)
                    {
                        MdiParent = MdiParent
                    };
                    medicineForm.Show();
                    medicineForm.Dock = DockStyle.Fill;
                    Close();
                }
            }
        }

        private void removeMedicineButton_Click(object sender, EventArgs e)
        {
            if (medicinesDataGridView.SelectedRows.Count > 0)
            {
                int index = medicinesDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(medicinesDataGridView[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                Medicine medicine = db.Medicines.Find(id);

                if (medicine != null)
                {
                    if (MessageBox.Show("Удалить " + medicine.Name + " ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.Medicines.Remove(medicine);
                        db.SaveChanges();
                        medicinesBindingSource.DataSource = db.Medicines.ToList();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
