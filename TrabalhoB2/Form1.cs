using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoB2
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
            if (MessageBox.Show("Deseja sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Botão Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite o usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite a senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                loginInf login = new loginInf();

                login.usuario = txtUsuario.Text;
                login.senha = txtSenha.Text;

                if (login.usuario == "admin" && login.senha == "admin")
                {
                    MessageBox.Show("Bem vindo " + login.usuario + "!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    menuPrincipal menu = new menuPrincipal();
                    menu.Show();
                } else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
        }
        #endregion
    }
}
