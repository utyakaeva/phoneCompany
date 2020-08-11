using System;
using System.Windows.Forms;

namespace telCom_2._1
{
    public partial class ClientMainForm : Form
    {
        public ClientMainForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Пользователь: {global.CurrentUser.Login} ({GetUserRoleName(global.CurrentUser.Position)})";

        }
          string GetUserRoleName(string position)
        {
            switch (position)
            {
                case WorkerRoles.Admin: return "администратор";
                case WorkerRoles.Buh: return "бухгалтер";
                case WorkerRoles.Manager: return "менеджер";
                default: return position;
            }
        }

        private void button1Data_Click(object sender, EventArgs e)
        {
            var client = all_Client.FindById(global.CurrentUser.Id);
           // client.Edit();
        }

        private void button2HistoryPayment_Click(object sender, EventArgs e)
        {
            var tariffHistory = all_Tariff.FindById(global.CurrentUser);
            tariffHistory.ToString();
            //new TariffHistoryForm(global.CurrentUser as Client).ShowDialog();
        }

        private void button3HistoryCall_Click(object sender, EventArgs e)
        {
            //new CallHistoryForm(global.CurrentUser as Client1).ShowDialog();
        }
    }
}
