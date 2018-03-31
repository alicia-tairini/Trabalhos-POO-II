using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia.css
{
    class ClassSair
    {
        public void fim()
        {
            string texto = "Deseja finalizar o Sistema de média", cabec = "Finalizar";
            if (MessageBox.Show(texto, cabec, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
