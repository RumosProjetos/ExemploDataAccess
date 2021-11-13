using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst.Model
{
    public class PlataformaDBContext : DbContext
    {
        public PlataformaDBContext() : base("name=DatabaseDeJogos")
        {

        }

        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
    }
}
