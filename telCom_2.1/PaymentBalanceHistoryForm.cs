using System;
using System.Windows.Forms;

namespace telCom_2._1
{
    internal class PaymentBalanceHistoryForm : Form
    {
        private Client client;

        public PaymentBalanceHistoryForm(Client client)
        {
            this.client = client;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
            {
             //   textBox1.Text = client.Login;

                //using (var context = Global.CreateContext())
                {
                    //balanceBindingSource.DataSource = client.GetBalanceHistory();
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
    }


