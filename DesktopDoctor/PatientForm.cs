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
    public partial class PatientForm : Form
    {
        Patient patient;

        public PatientForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }
    }
}
