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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm(MainForm mainForm)
        {
            InitializeComponent();
            MdiParent = mainForm;
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // medicinesBindingSource.DataSource = (MdiParent as MainForm).db.Medicines.ToList();
        }
    }
}
