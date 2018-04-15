using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabB1Cadastro.cs
{
    public class ClassPessoa : Metodos
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Turno { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public int DataNascimento { get; set; }

        #region Calculando Idade
        public int calculaIdade(DateTime dtNasc)
        {
            TimeSpan result = DateTime.Now.Date - dtNasc;
            //este calculo encontra em dias
            int calc = result.Days / 365;
            return calc;  
        }
        #endregion
    }
}
