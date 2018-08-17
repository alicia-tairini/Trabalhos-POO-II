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
    public partial class sobre : Form
    {
        public sobre()
        {
            InitializeComponent();
        }

        #region Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            menuPrincipal menu = new menuPrincipal();

            this.Close();
            menu.Show();
        }
        #endregion
    }
}
