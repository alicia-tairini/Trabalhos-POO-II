using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabB1Cadastro.cs
{
    public class ClasProfessor : ClassPessoa
    {
        public String Materia { get; set; }
        public int NunAulasSemana { get; set; }
        public int NunDias{ get; set; }
    }
}
