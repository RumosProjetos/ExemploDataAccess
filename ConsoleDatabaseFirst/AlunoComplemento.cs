using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatabaseFirst
{
    public partial class Aluno
    {
        public int Idade => DateTime.Today.Year - DataNascimento.Year;
    }
}
