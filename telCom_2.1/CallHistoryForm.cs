using System;
using System.Windows.Forms;

namespace telCom_2._1
{
    public partial class CallHistoryForm :Form
    {
        private Client1 client1;

        public CallHistoryForm(Client1 client1)
        {
            this.client1 = client1;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
            {
                //textBox1.Text = client.Login;

                //using (var context = Global.CreateContext())
                {
                    //callBindingSource.DataSource = all_Call.FindAll(new Call(), new Data.Call(), true, 0, 0);
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
    }


