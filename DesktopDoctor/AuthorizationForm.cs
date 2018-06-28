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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void ToPatientsButton_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm
            {
                MdiParent = MdiParent
            };
            patientsForm.Show();
            Close();
        }

        private void ToMedicinesButton_Click(object sender, EventArgs e)
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
