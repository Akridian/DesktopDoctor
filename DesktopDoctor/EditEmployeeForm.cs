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
    public partial class EditEmployeeForm : Form
    {
        Employee employee;

        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
    }
}
