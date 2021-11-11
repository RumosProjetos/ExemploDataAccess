using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploDataAccess
{
    public class Exemplo
    {
        public void ListarAlunos()
        {
            var escola = new EscolaDBEntities();
            var alunos = escola.Alunoes.ToList();
     
        }
    }
}