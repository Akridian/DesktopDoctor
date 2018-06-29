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
        DesktopDoctorDatabaseEntities db = new DesktopDoctorDatabaseEntities();

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.ToString();
            string password = passwordTextBox.Text.ToString();
            try
            {
                Account account = db.Accounts.Where(acc => acc.Login == login).Select(acc => acc).First();
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
    }
}
