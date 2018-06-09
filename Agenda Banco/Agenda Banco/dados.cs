using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Banco
{
    class dados
    {
        public static string Stringdeconexao
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;
                        AttachDbFilename=C:\Users\Alicia Tairini\Documents\Agenda.mdf;
                        Integrated Security=True;Connect Timeout=30";
            }
        }
    }
}
