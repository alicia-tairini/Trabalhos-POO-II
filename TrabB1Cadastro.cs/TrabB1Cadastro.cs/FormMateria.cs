using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabB1Cadastro.cs
{
    public partial class FormMateria : Form
    {
        public FormMateria()
        {
            InitializeComponent();
        }

        #region Btn Adicionar 
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string valor = txtItem.Text;
            if (valor == "")
            {
                MessageBox.Show("Digite a Materia a ser adicionada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                string nome = txtItem.Text;
                lstItem.Items.Add(nome.ToUpper());
                txtItem.Clear();
                txtItem.Focus();
            }
        }
      
        #endregion

        #region Btn Remover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            int valor = lstItem.SelectedIndex;
            if (valor == -1)
            {
                MessageBox.Show("Selecione um icone para exluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                lstItem.Items.RemoveAt(valor);
            }
        }
        #endregion

        #region Btn Remover Tudo
        private void btnRemoverTudo_Click(object sender, EventArgs e)
        {
            if (lstItem.Items.Count == 0)
            {
                MessageBox.Show("A lista esta vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtItem.Clear();
                lstItem.Items.Clear();
                txtItem.Focus();
            }
        }
        #endregion

        #region Btn Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Btn Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja voltar ao MENU?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}