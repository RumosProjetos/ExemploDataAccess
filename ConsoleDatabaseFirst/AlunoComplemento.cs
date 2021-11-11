using System;

namespace ConsoleDatabaseFirst
{
    public partial class Aluno
    {
        public int Idade => DateTime.Today.Year - DataNascimento.Year;
    }
}
