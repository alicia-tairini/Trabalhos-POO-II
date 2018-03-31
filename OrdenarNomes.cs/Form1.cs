using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenarNomes.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            ClassSair saida = new ClassSair();
            saida.fim();
        }
        
        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txt1nome.Clear();
            txt2nome.Clear();
            txt3nome.Clear();
            txt4nome.Clear();
            txt5nome.Clear();
            lstNomes.Items.Clear();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lstNomes.Items.Clear();
            string[] nome = new string[5];
            nome[0] = txt1nome.Text.ToUpper();
            nome[1] = txt2nome.Text.ToUpper();
            nome[2] = txt3nome.Text.ToUpper();
            nome[3] = txt4nome.Text.ToUpper();
            nome[4] = txt5nome.Text.ToUpper();

            // Ordenar vetor
            Array.Sort(nome);

            // Apresentar o valor saida
            foreach (var valor in nome)
            {
                lstNomes.Items.Add(valor);
            }

        }
    }
   
}
