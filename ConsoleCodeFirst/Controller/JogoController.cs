using ConsoleCodeFirst.Dto;
using ConsoleCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst.Controller
{
    public class JogoController
    {
        public Jogo ObterJogoPorId(int id)
        {
            var dbContext = new PlataformaDBContext();
            return dbContext.Jogos.FirstOrDefault(x => x.Id == id);
        }

        public List<Jogo> ListarTodos()
        {
            var dbContext = new PlataformaDBContext();
            return dbContext.Jogos.ToList();
        }

        public void AdicionarJogo(Jogo jogo)
        {
            var dbContext = new PlataformaDBContext();
            dbContext.Jogos.Add(jogo);
            dbContext.SaveChanges();
        }

        public void ApagarJogo(Jogo jogo)
        {
            var dbContext = new PlataformaDBContext();
            dbContext.Jogos.Remove(jogo);
            dbContext.SaveChanges();
        }


        /// <summary>
        /// TODO: Incluir DTO e separar do Modelo
        /// </summary>
        /// <param name="jogo"></param>
        /// <param name="jogoNovosDados"></param>
        public void AtualizarJogo(int id, JogoDto jogoDto)
        {
            var dbContext = new PlataformaDBContext();
            var jogo = dbContext.Jogos.FirstOrDefault(x => x.Id == id);
            jogo.Nome = jogoDto.Nome;
            jogo.TipoJogo = jogoDto.TipoJogo;

       
            dbContext.SaveChanges();
        }
    }
}
