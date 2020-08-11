using System;
using System.Windows.Forms;

namespace telCom_2._1
{
    public partial class AddPaymentForm : Form
    {
        public Client1 client;

        public AddPaymentForm(Client1 client)
        {
            this.client = client;
        }
    }
}