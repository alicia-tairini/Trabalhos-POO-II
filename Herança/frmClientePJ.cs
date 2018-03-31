using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herança
{
    public partial class frmClientePJ : Form
    {
        public frmClientePJ()
        {
            InitializeComponent();
        }
        #region btnFechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fechar formulario", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
            #endregion

            #region btnOK

            private void btnOK_Click(object sender, EventArgs e)
        {
            ClientePJ pj = new ClientePJ();
            pj.Nome = txtNome.Text;
            pj.CNPJ = txtCNPJ.Text;
            pj.Email = txtEmail.Text;
            pj.Telefone = txtTelefone.Text;

            lblMensagem.Text = "O cliente " + pj.Nome + "\n" +
                "CPF " + pj.CNPJ + "\n" +
                "Telefone " + pj.Telefone + "\n" +
                "E-Mail" + pj.Email;
        }
        #endregion
    }
}
