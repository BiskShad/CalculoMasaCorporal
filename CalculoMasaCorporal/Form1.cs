using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMasaCorporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label1 = textPeso.Text;
            int peso = Int32.Parse(label1);
           
            string label2 = textAltura.Text;
            double altura = double.Parse(label2);

            double imc = peso / (altura * altura);

            MessageBox.Show("El indice de masa corporal es de : " + imc);

        }
    }
}
