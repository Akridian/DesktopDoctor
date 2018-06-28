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
    public partial class EditPatientForm : Form
    {
        Patient patient;

        public EditPatientForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }
    }
}
