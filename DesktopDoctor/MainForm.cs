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
        public Account account;

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

        public void Authorization(Account account)
        {
            this.account = account;
            if (account.SecurityLevel.Code == "doctor")
            {
                ToolStripMenuItem patientsMenuItem = new ToolStripMenuItem("Пациенты");
                patientsMenuItem.Click += PatientsMenuItem_Click;
                topMenuStrip.Items.Add(patientsMenuItem);
                MdiChildren.First().Close();
                PatientsForm patientsForm = new PatientsForm
                {
                    MdiParent = this
                };
                patientsForm.Show();
                patientsForm.Dock = DockStyle.Fill;
            }
            else if (account.SecurityLevel.Code == "admin")
            {
                MdiChildren.First().Close();
                MedicinesForm medicinesForm = new MedicinesForm
                {
                    MdiParent = this
                };
                medicinesForm.Show();
                medicinesForm.Dock = DockStyle.Fill;
            }
        }

        private void PatientsMenuItem_Click(object sender, EventArgs e)
        {
            MdiChildren.First().Close();
            PatientsForm patientsForm = new PatientsForm
            {
                MdiParent = this
            };
            patientsForm.Show();
            patientsForm.Dock = DockStyle.Fill;
        }
    }
}
