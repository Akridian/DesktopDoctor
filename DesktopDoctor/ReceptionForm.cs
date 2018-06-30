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
    public partial class ReceptionForm : Form
    {
        Reception reception;

        public ReceptionForm(MainForm mainForm, Reception reception)
        {
            InitializeComponent();
            MdiParent = mainForm;
            this.reception = reception;
        }
    }
}
