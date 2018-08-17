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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        #region Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o programa?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Menu - Cadastro de Clientes
        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCli cliente = new cadCli();

            cliente.Show();
            this.Hide();            
        }
        #endregion

        #region Menu - Cadastro de Fornecedores
        private void cadastroDeFornedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadForn fornecedor = new cadForn();

            fornecedor.Show();
            this.Hide();            
        }
        #endregion

        #region Menu - Pedidos
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadPed pedido = new cadPed();

            pedido.Show();
            this.Hide();            
        }
        #endregion

        #region Menu - Sobre
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre grupoTrab = new sobre();

            this.Hide();
            grupoTrab.Show();
        }
        #endregion
    }
}
