using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Pessoa obj = new Pessoa();
            obj.Nome = txtNome.Text;
            obj.Idade = Convert.ToInt32(txtIdade.Text);
            obj.Sexo = txtSexo.Text;
            MessageBox.Show(obj.Nome + " Possui " + obj.Idade.ToString() + " Anos e é do sexo" + obj.Sexo);

        
        }
    }
}
