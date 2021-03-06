﻿using System;
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
            UpdateViewEmployees();
        }

        private void UpdateViewEmployees()
        {
            List<Account> accounts = (MdiParent as MainForm).db.Accounts.ToList();
            List<Employee> employees = (MdiParent as MainForm).db.Employees.ToList();
            List<SecurityLevel> securityLevels = (MdiParent as MainForm).db.SecurityLevels.ToList();

            List<AccountView> result = new List<AccountView>();

            foreach (var account in accounts)
            {
                AccountView accountView = new AccountView
                {
                    ID = account.EmployeeId,
                    Login = account.Login,
                    Fename = employees.Find(a => a.Id == account.EmployeeId).Fename,
                    Name = employees.Find(a => a.Id == account.EmployeeId).Name,
                    Patronymic = employees.Find(a => a.Id == account.EmployeeId).Patronymic,
                    SecurityLevel = securityLevels.Find(a => a.Id == account.SecurityLevelId).Name,
                    IsDeleted = employees.Find(a => a.Id == account.EmployeeId).IsDeleted
                };
                if (!accountView.IsDeleted)
                {
                    result.Add(accountView);
                }
            }
            employeesBindingSource.DataSource = result;
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToMedicinesForm();
        }

        private void AddNewEmployeeButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToEditEmployeeForm(new Employee());
        }

        private void ChangeEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.SelectedRows.Count > 0)
            {
                int id = (employeesBindingSource.Current as AccountView).ID;
                Employee employee = (MdiParent as MainForm).db.Employees.Find(id);
                if (employee != null)
                {
                    (MdiParent as MainForm).GoToEditEmployeeForm(employee);
                }
            }
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.SelectedRows.Count > 0)
            {

                int id = (employeesBindingSource.Current as AccountView).ID;
                Employee employee = (MdiParent as MainForm).db.Employees.Find(id);

                if (employee != null)
                {
                    if (MessageBox.Show("Удалить " + employee.ToString() + " ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        List<Account> accounts = (MdiParent as MainForm).db.Accounts.ToList();
                        int idAccount = accounts.Find(a => a.EmployeeId == employee.Id).Id;
                        Account account = (MdiParent as MainForm).db.Accounts.Find(idAccount);

                        if (account.SecurityLevel.Code == "admin")
                        {
                            if (CheckRemoveLastAdmin())
                            {
                                MessageBox.Show("Нельзя удалить.\nВ системе должен быть администратор.", Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                        }
                        (MdiParent as MainForm).db.Accounts.Remove(account);
                        employee.IsDeleted = true;
                        (MdiParent as MainForm).db.SaveChanges();
                        UpdateViewEmployees();
                    }
                    else
                    {
                        return;
                    }
                }

            }
        }

        private bool CheckRemoveLastAdmin()
        {
            List<Account> accounts = (MdiParent as MainForm).db.Accounts.ToList();
            List<Account> result = accounts.FindAll(a => a.SecurityLevel.Code == "admin");

            if(result.Count > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
