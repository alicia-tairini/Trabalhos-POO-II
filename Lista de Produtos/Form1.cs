using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listade_Produtos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #region Botão Adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtItem.Text;
            listProdutos.Items.Add(nome.ToUpper());
            txtItem.Clear();
            txtItem.Focus();
        }
        #endregion

        #region Botão Remover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            int valor = listProdutos.SelectedIndex;
            if (valor == -1)
            {
                MessageBox.Show("Selecione um icone para exluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                listProdutos.Items.RemoveAt(valor);
            }
        }
        #endregion

        #region Botão Remover Tudo
        private void btnRemvTudo_Click(object sender, EventArgs e)
        {
            if (listProdutos.Items.Count == 0)
            {
                MessageBox.Show("A lista esta vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                listProdutos.Items.Clear();
                txtItem.Focus();
            }

        }
        #endregion

        #region Botão cancelar
        private void btbCancelar_Click(object sender, EventArgs e)
        {
            txtItem.Clear();
            txtItem.Focus();
        }
        #endregion

        #region Botão sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }  
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }

}
