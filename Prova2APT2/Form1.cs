using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2APT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(textBox2.Text, textBox2.Text, maskedTextBox1.Text, comboBox2.Text, Convert.ToDouble(textBox3.Text.ToString()));
            (double s, double i) = funcionario.Calcular_salario(funcionario.Salario, funcionario.Funcao);
            label9.Text = s.ToString("C2");
            label10.Text = i.ToString("C2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
