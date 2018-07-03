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
    public partial class SelectMedicineForm : Form
    {
        ReceptionForm parent;
        List<Medicine> availableMedicines;

        public SelectMedicineForm(ReceptionForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            availableMedicines = new List<Medicine>();
            availableMedicines = (parent.MdiParent as MainForm).db.Medicines.Where(med => !med.IsDeleted).ToList();
            List<Medicine> copy = availableMedicines.ToList();
            foreach (Medicine med in copy)
            {
                if (parent.medicines.Contains(med))
                {
                    availableMedicines.Remove(med);
                }
            }
            medicineBindingSource.DataSource = availableMedicines;
        }

        private void MedicineDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Medicine medicine = medicineBindingSource.Current as Medicine;
            parent.AddMedicine(medicine);
            availableMedicines.Remove(medicine);
            medicineBindingSource.CurrencyManager.Refresh();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            availableMedicines = (parent.MdiParent as MainForm).db.Medicines.Where(med => !med.IsDeleted && med.Name.StartsWith(nameTextBox.Text) && med.Description.StartsWith(descriptionTextBox.Text)).ToList();
            List<Medicine> copy = availableMedicines.ToList();
            foreach (Medicine med in copy)
            {
                if (parent.medicines.Contains(med))
                {
                    availableMedicines.Remove(med);
                }
            }
            medicineBindingSource.DataSource = availableMedicines;
        }
    }
}
