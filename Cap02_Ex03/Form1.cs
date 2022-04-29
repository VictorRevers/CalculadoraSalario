using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap02_Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float val_hora = float.Parse(textBox1.Text);
            float horas_trab = float.Parse(textBox2.Text);
            float porc_desconto = float.Parse(textBox3.Text);

            float bruto = (val_hora * horas_trab) * 30;
            float desconto = bruto * (porc_desconto / 100);
            float liquido = bruto - desconto;

            label5.Text += "\n" +bruto.ToString("##,##0.00");
            label6.Text += "\n"+desconto.ToString("##,##0.00");
            label7.Text += "\n"+liquido.ToString("##,##0.00");

        }
    }
}
