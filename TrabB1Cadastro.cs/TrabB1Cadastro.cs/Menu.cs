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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno form = new FormAluno();
                 form.ShowDialog();
        }

        private void cadastroProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessor form = new FormProfessor();
            form.ShowDialog();
        }

        private void cadastroMateria_Click(object sender, EventArgs e)
        {
            FormMateria form = new FormMateria();
            form.ShowDialog();
        }
    }
}
