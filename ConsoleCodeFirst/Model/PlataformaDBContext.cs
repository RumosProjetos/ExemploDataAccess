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
#if DEBUG
            //Database.SetInitializer(new DropCreateDatabaseAlways<PlataformaDBContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PlataformaDBContext>());            
#endif

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PlataformaDBContext>());
        }

        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<JogoDeConsole> JogoDeConsoles { get; set; }
        public DbSet<Progresso> Progressos { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }

        public DbSet<ConteudoBaixado> ConteudoBaixados { get; set; }
    }
}
