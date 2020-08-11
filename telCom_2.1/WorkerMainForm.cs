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
    public partial class WorkerMainForm : Form
    {
        public WorkerMainForm()
        {
            InitializeComponent();
        }
        //Добавим найденные в выпадающий список
            cmbWorker.Items.Clear();
            cmbBooks.Items.AddRange(books.ToArray());
       // cmbWorker.DataSource = WorkerBindingSource; //заполнение выпадающего списка
            
           // WokerBindingSource.DataSource = Worker.Data; //заполнение списка
           

       // void RefreshAll()
       // {
         //   RefreshCities();
          //  RefreshClients();
          //  RefreshTariffs();
          //  RefreshWorkers();
       // }


        private void OnViewPaymentsClick(object sender, EventArgs e)
        {
            var selection = GridHelper.GetSelection<Client>(dataGridView2);
            if (selection.Count > 0)
            {
                new PaymentBalanceHistoryForm(selection[0]).ShowDialog();
            }
        }

        public void OnMakePaymentClick(object sender, EventArgs e)
        {
            var selection = GridHelper.GetSelection<Client>(dataGridView2);
            if (selection.Count > 0)
            {
                if (new AddPaymentForm(selection[0]).ShowDialog() == DialogResult.OK)
                RefreshClients();
            }
        }

        private void RefreshClients()
        {
            throw new NotImplementedException();
        }

        private void OnViewCallsHistoryClick(object sender, EventArgs e)
        {
            var selection = GridHelper.GetSelection<Client1>(dataGridView2);
            if (selection.Count > 0)
            {
                new CallHistoryForm(selection[0]).ShowDialog();
            }
        }


        private void OnClientsFilterReset(object sender, EventArgs e)
        {

        }

        private void OnClientsFilterApply(object sender, EventArgs e)
        {

        }

        private void OnDeleteClientClick(object sender, EventArgs e)
        {

        }

        private void OnEditClientClick(object sender, EventArgs e)
        {

        }

        private void OnAddClientClick(object sender, EventArgs e)
        {

        }
      
        private void WorkerMainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telComDataSet.City1". При необходимости она может быть перемещена или удалена.
            this.city1TableAdapter.Fill(this.telComDataSet.City1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telComDataSet.Tariff1". При необходимости она может быть перемещена или удалена.
            this.tariff1TableAdapter.Fill(this.telComDataSet.Tariff1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telComDataSet.Worker1". При необходимости она может быть перемещена или удалена.
            this.worker1TableAdapter.Fill(this.telComDataSet.Worker1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telComDataSet.Client1". При необходимости она может быть перемещена или удалена.
            this.client1TableAdapter.Fill(this.telComDataSet.Client1);
            this.Text = $"Пользователь: {global.CurrentUser.Login} ({GetUserRoleName(global.CurrentUser.Position)})";
            comboBox1.DataSource = new string[]
            {
                "",
                WorkerRoles.Admin,
                WorkerRoles.Buh,
                WorkerRoles.Manager
            };
           
            if (global.CurrentUser.IsWorker)
            {
                if (global.CurrentUser.Position != WorkerRoles.Admin)
                    tabControl1.TabPages.Remove(tabPage1);

                if (global.CurrentUser.Position == WorkerRoles.Buh)
                {
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                       button12.Hide();
                }
                  if (global.CurrentUser.Position == WorkerRoles.Manager)
                {
                    button10.Hide();
                }
                   comboBox3.DataSource = new string[]
                 {
                    "нет",
                  "Логин",
                   "Адрес",
                  "Баланс",
                  "Должность",
                  "Тариф"
            };
            }
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
             private void button8_Click(object sender, EventArgs e)//добавление звонка
        {
            var selection = GridHelper.GetSelection<Client>(dataGridView2);
            if (selection.Count > 0)
            {
                if (new AddCallForm(selection[0]).ShowDialog() == DialogResult.OK) ;
               
            }
        }

        private void button17_Click_1(object sender, EventArgs e)//сбросить фильтр на вкладке Тарифы
        {
            textBox8.Text = "";
            textBox8.Text = "";
            textBox8.Text = "";
            //RefreshTariffs();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
        
    
