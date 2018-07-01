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
            List<Account> accounts = (MdiParent as MainForm).db.Accounts.ToList();
            List<Employee> employees = (MdiParent as MainForm).db.Employees.ToList();
            List<SecurityLevel> securityLevels = (MdiParent as MainForm).db.SecurityLevels.ToList();

            List<AccountView> result = new List<AccountView>();

            foreach (var account in accounts)
            {
                AccountView accountView = new AccountView();
                accountView.Login = account.Login;
                accountView.Fename = employees.Find(a => a.Id == account.EmployeeId).Fename;
                accountView.Name = employees.Find(a => a.Id == account.EmployeeId).Name;
                accountView.Patronymic = employees.Find(a => a.Id == account.EmployeeId).Patronymic;
                accountView.SecurityLevel = securityLevels.Find(a => a.Id == account.SecurityLevelId).Name;
                result.Add(accountView);
            }
            employeesBindingSource.DataSource = result;
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToMedicinesForm();
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToEditEmployeeForm(new Employee());
        }
    }
}
