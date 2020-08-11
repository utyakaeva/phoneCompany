using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telCom_2._1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            login.Text = global.Login;
            password.Text = global.Pass;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
       
        private void buttonUserEntrance_Click(object sender, EventArgs e)
        {
            var mmm = global.TryLogin(login.Text, password.Text, false);
            if (mmm == null)
            {
                global.Login = login.Text;
                global.Pass = password.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Ошибка авторизации: " + mmm);
        }

        private void buttonWorkerEntrance_Click_1(object sender, EventArgs e)
        {
            var mmm = global.TryLogin(login.Text, password.Text, true);
            if (mmm == null)
            {
                global.Login = login.Text;
                global.Pass = password.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Ошибка авторизации: " + mmm);
        }

       
    }
}

    

