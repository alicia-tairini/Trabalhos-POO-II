using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenarNomes.cs
{
    class ClassSair
    {
        public void fim()
        {
            string texto = "Encerrar o sistema de ordenação?", cabec = "Finalizar"; 

            if (MessageBox.Show(texto, cabec, MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
