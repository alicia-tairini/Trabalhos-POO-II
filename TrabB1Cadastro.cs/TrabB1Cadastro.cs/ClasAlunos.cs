using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabB1Cadastro.cs
{
    public class ClasAlunos : ClassPessoa
    {
        public string Curso { get; set; }
        public int RA { get; set; }
        public int Serie { get; set; }
    }
}