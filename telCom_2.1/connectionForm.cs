using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telCom_2._1
{
    public partial class connectionForm : Form
    {
        public connectionForm()
        {
            InitializeComponent();
            TextBox1.Text = global.ConnectionString;
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            global.ConnectionString = TextBox1.Text;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

    

