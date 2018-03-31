using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia.css
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClassSair saida = new ClassSair();
            saida.fim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            lblResultado.Text = "";
            txt1.Focus();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double[] nota;
            nota = new double[4];

            nota[0] = Convert.ToDouble(txt1.Text);
            nota[1] = Convert.ToDouble(txt2.Text);
            nota[2] = Convert.ToDouble(txt3.Text);
            nota[3] = Convert.ToDouble(txt4.Text);

            double acumulado = 0;

            foreach (var soma in nota)
            {
                acumulado += soma;
            }
            double media = Math.Round((acumulado / 4), 4);

            lblResultado.Text = ("Media das notas é " + Convert.ToString(media));
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // escrever codigo cel

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
    }

