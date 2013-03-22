using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Correios.Net;

namespace Exemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Address address = BuscaCep.GetAddress(textBox5.Text);

            textBox1.Text = address.Street;
            textBox2.Text = address.District;
            textBox3.Text = address.City;
            textBox4.Text = address.State;
        }
    }
}
