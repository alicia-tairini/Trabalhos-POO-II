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
    public partial class frmClientePF : Form
    {
        public frmClientePF()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        #region btnOK
        private void btnOK_Click(object sender, EventArgs e)
        {
            ClientePF pf = new ClientePF();
            pf.Nome = txtNome.Text;
            pf.CPF = txtCPF.Text;
            pf.Telefone = txtTelefone.Text;
            pf.Email = txtEmail.Text;

            lblMensagem.Text = "O cliente " + pf.Nome + "\n" +
                "CPF " + pf.CPF + "\n" +
                "Telefone " + pf.Telefone + "\n" +
                "E-Mail" + pf.Email;
        }
        #endregion

        #region btnFechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fechar formulario", "Fechar",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }

        }
        #endregion
    }
}
