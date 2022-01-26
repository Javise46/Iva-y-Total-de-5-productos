using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iva_y_Total_de_5_productos
{
    public partial class Form1 : Form
    {
        
        private Totales op = new Totales();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void IniciarB_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double n3;
            double n4;
            double n5;
            Tp.Text = op.TotalValor(n1 = double.Parse(txb1.Text), n2 = double.Parse(txb2.Text), n3 = double.Parse(txb3.Text), n4 = double.Parse(txb4.Text), n5 = double.Parse(txb5.Text)).ToString();
            Ti.Text = op.TotalValor2(n1 = double.Parse(txb1.Text), n2 = double.Parse(txb2.Text), n3 = double.Parse(txb3.Text), n4 = double.Parse(txb4.Text), n5 = double.Parse(txb5.Text)).ToString();
        }
    }
}
