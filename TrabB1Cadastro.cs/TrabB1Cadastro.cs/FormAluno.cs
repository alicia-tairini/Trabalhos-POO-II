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
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }

        #region Btn Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar o Sistema?", "FInalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Btn Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validando TEXT
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
            else if (txtCurso.Text == string.Empty)
            {
                MessageBox.Show("Campo CURSO vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurso.BackColor = Color.Red;
            }
            else if (!txtRa.MaskCompleted)
            {
                MessageBox.Show("Campo R.A  vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRa.BackColor = Color.Red;;
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

        #region Btn Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        #region Btn Menu
        private void btnMENU_Click(object sender, EventArgs e)
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
        public void LimpaTela()
        {
            txtIdade.Clear();
            txtNome.Clear();
            txtRa.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtCurso.Clear();
            txtTurno.Items.Clear();
            txtSexo.Items.Clear();
            txtNome.Focus();
        }
        #endregion
    }
}