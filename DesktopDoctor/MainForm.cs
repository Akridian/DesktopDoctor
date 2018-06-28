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
    public partial class MainForm : Form
    {
        public Employee employee;

        public MainForm()
        {
            InitializeComponent();
            AuthorizationForm authorizationForm = new AuthorizationForm
            {
                MdiParent = this
            };
            authorizationForm.Show();
            authorizationForm.Dock = DockStyle.Fill;
        }
    }
}
