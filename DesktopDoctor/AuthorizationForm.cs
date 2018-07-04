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
        public AuthorizationForm(MainForm mainForm)
        {
            InitializeComponent();
            MdiParent = mainForm;
        }

        private void Authorization()
        {
            string login = loginTextBox.Text.ToString();
            string password = passwordTextBox.Text.ToString();
            try
            {
                Account account = (MdiParent as MainForm).db.Accounts.Where(acc => acc.Login == login).ToList().Where(acc => acc.Login == login).First();
                if (account.Password == password)
                {
                    (MdiParent as MainForm).Authorization(account);
                }
                else
                {
                    MessageBox.Show("Неправильный пароль");
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Аккаунт не найден");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Authorization();
        }

        private void AuthorizationForm_Resize(object sender, EventArgs e)
        {
            loginPanel.Location = new Point(Size.Width / 2 - loginPanel.Width / 2, Size.Height / 2 - loginPanel.Height / 2);
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authorization();
            }
        }
    }
}
