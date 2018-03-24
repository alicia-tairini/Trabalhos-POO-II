using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Botão adicionar Item 

        private void button1_Click(object sender, EventArgs e)
        {
            Adicionar();
        }
        #endregion

        #region Botão remover Intem
        private void btnRemover_Click(object sender, EventArgs e)
        {
            int valor = lstItem.SelectedIndex;
            if(valor == -1)
            {
                MessageBox.Show("Selecione um intem para excluir",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                lstItem.Items.RemoveAt(valor);
            }
        }
        #endregion

        #region Botão Remover tudo
        private void btnTudo_Click(object sender, EventArgs e)
        {
            if (lstItem.Items.Count == 0)
            {
                MessageBox.Show("A lista está vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
            else
            {
                lstItem.Items.Clear();
                txtItem.Focus();
            }
        }
        #endregion

        #region Botão cancelar 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtItem.Clear();
            txtItem.Focus();
        }
        #endregion

        #region Botão sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair? ", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }   
        }
        #endregion

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Adicionar();
            }
            
        }

        // metodo 
        private void Adicionar() {
            string nome = txtItem.Text;
            if (nome.Trim().Length == 0)
            {
                MessageBox.Show("Digite algo no campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstItem.Items.Add(nome.Trim().ToUpper());
                txtItem.Clear();
                txtItem.Focus();
            }

        }

    }
}
