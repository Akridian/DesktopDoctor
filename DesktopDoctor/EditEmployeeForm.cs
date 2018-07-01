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

        public EditEmployeeForm(MainForm mainForm, Employee employee)
        {
            InitializeComponent();
            MdiParent = mainForm;
            this.employee = employee;

            // ====

            passwordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            SecurityLevelsBindingSource.DataSource = (MdiParent as MainForm).db.SecurityLevels.ToList();
            FillFields();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            (MdiParent as MainForm).GoToEmployeesForm();
        }

        private void FillFields()
        {
            if(employee.Id != 0)
            {
                ConfirmButton.Text = "Изменить";

                List<Account> accounts = (MdiParent as MainForm).db.Accounts.ToList();
                List<SecurityLevel> levels = (MdiParent as MainForm).db.SecurityLevels.ToList();

                loginTextBox.Text = accounts.Find(a => a.EmployeeId == employee.Id).Login;
                passwordTextBox.Text = accounts.Find(a => a.EmployeeId == employee.Id).Password;
                confirmPasswordTextBox.Text = accounts.Find(a => a.EmployeeId == employee.Id).Password;

                SecurityLevelsComboBox.SelectedItem = levels.Find(l => l.Id == accounts.Find(a => a.EmployeeId == employee.Id).SecurityLevelId);

                fenameTextBox.Text = employee.Fename;
                nameTextBox.Text = employee.Name;
                patronimicTextBox.Text = employee.Patronymic;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordTextBox.Text = string.Empty;
        }

        private bool ValidationInput()
        {
            foreach(Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrWhiteSpace((control as TextBox).Text))
                    {
                        MessageBox.Show("Не все поля заполнены", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            if (!CompareConfirmPassword()) return false;

            return true;
        }

        private bool CompareConfirmPassword()
        {
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Подтверждение пароля не корректно", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                if (employee.Id == 0)
                {
                    Account account = new Account();

                    employee.Fename = fenameTextBox.Text;
                    employee.Name = nameTextBox.Text;
                    employee.Patronymic = patronimicTextBox.Text;

                    (MdiParent as MainForm).db.Employees.Add(employee);
                    (MdiParent as MainForm).db.SaveChanges();

                    account.Login = loginTextBox.Text;
                    account.Password = passwordTextBox.Text;
                    account.Employee = (MdiParent as MainForm).db.Employees.Find(employee.Id);
                    account.SecurityLevel = (MdiParent as MainForm).db.SecurityLevels.Find(((SecurityLevel)SecurityLevelsComboBox.SelectedItem).Id);

                    (MdiParent as MainForm).db.Accounts.Add(account);
                    (MdiParent as MainForm).db.SaveChanges();

                    MessageBox.Show("Добавлен новый пользователь", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    (MdiParent as MainForm).GoToEmployeesForm();
                }
                else
                {
                    List<Account> accounts = (MdiParent as MainForm).db.Accounts.ToList();
                    Account editAccount = (MdiParent as MainForm).db.Accounts.Find(accounts.Find(a => a.EmployeeId == employee.Id).Id);

                    Employee editEmployee = (MdiParent as MainForm).db.Employees.Find(employee.Id);

                    editEmployee.Fename = fenameTextBox.Text;
                    editEmployee.Name = nameTextBox.Text;
                    editEmployee.Patronymic = patronimicTextBox.Text;

                    editAccount.Login = loginTextBox.Text;
                    editAccount.Password = passwordTextBox.Text;
                    editAccount.Employee = editEmployee;
                    editAccount.SecurityLevel = (MdiParent as MainForm).db.SecurityLevels.Find(((SecurityLevel)SecurityLevelsComboBox.SelectedItem).Id);

                    (MdiParent as MainForm).db.SaveChanges();

                    MessageBox.Show(" Пользователь изменен", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    (MdiParent as MainForm).GoToEmployeesForm();
                }
            }
        }
    }
}
