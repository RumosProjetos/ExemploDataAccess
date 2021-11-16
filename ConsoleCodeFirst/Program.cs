using ConsoleCodeFirst.Controller;
using ConsoleCodeFirst.Model;
using System;

namespace ConsoleCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new JogoController();

            //ExemploAdicao
            var jogoNovo = new Jogo
            {
                Nome = "God Of War",
                Finalizado = true,
                DataLancamento = DateTime.Now
            };
            app.AdicionarJogo(jogoNovo);

            //Exemplo Edição
            app.AtualizarJogo(jogoNovo.Id, new Dto.JogoDto { Nome = "Deus da Guerra", Categoria = "Ação"            });

            //Exemplo apagar
            var jogoApagar = new Jogo
            {
                Nome = "God Of War 2"
            };
            app.AdicionarJogo(jogoApagar);
            app.ApagarJogoPorId(jogoApagar.Id);

            //Exemplo listagem
            var jogos = app.ListarTodos();

            foreach (var item in jogos)
            {
                Console.WriteLine(item.Nome);
            }

        }
    }
}
