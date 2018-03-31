using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attv_em_casa
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Pessoas obj = new Pessoas();
            obj.Nome = txtNome.Text;
            obj.Cpf = Convert.ToInt32(txtCpf.Text);
            obj.Idade = Convert.ToInt32(txtIdade.Text);
            obj.Sexo = txtSexo.Text;
            obj.Cidade = txtCidade.Text;
            MessageBox.Show("O numerdo do CPF de " + obj.Nome + " é " + obj.Cpf.ToString() + ", a sua Idade é " + obj.Idade.ToString() + " anos, é do sexo " + obj.Sexo + ", e reside na cidade de " + obj.Cidade + " .");
        }
    }
}
