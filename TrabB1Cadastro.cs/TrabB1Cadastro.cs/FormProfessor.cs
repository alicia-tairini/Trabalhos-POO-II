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
    public partial class FormProfessor : Form
    {
        public FormProfessor()
        {
            InitializeComponent();
        }

        #region Btn Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar o sistema?", "Finalizar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Btn cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validando TXT
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo NOME vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.Red;
            }
            else if (txtIdade.Text == string.Empty)
            {
                MessageBox.Show("Campo IDADE vazio, selecione uma DATA!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdade.BackColor = Color.Red;
            }
          
            else if (txtMateria.Text == string.Empty)
            {
                MessageBox.Show("Campo MATERIA vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMateria.BackColor = Color.Red;
                txtMateria.Focus();
            }
            else if (!txtTelefone.MaskCompleted)
            {
                MessageBox.Show("Campo TELEFONE vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefone.BackColor = Color.Red;
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Campo E-MAIL  vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("O CADASTRO FOI REALIZADO COM SUCESSO!", "Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTela();
            }
        }
        #endregion

        #region btn Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
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

        #region Data
        private void dtpData_Leave(object sender, EventArgs e)
        {
            ClassPessoa func = new ClassPessoa();
            txtIdade.Text = Convert.ToString(func.calculaIdade(dtpData.Value));
        }
        #endregion

        #region Função LimpaTela
        private void LimpaTela()
        {
            txtIdade.Clear();
            txtNome.Clear();
            txtMateria.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtTurno.Items.Clear();
            txtSexo.Items.Clear();
            txtNumMensal.Value = 0;
            txtNAulas.Value = 0;
            txtNome.Focus();
        }
        #endregion
    }
}