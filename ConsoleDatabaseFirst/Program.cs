using StackExchange.Profiling;
using StackExchange.Profiling.EntityFramework6;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniProfilerEF6.Initialize();
            var profiler = MiniProfiler.StartNew("My Profiler Name");

            using (profiler.Step("Main Work"))
            {
                //ObterTodosOsAlunos();
                ObterTodosOsAlunosComIdade();
                //ObterTodosOsAlunosQueComecemCom("A");
                //ObterTodosOsAlunosQuePossuemTelefone();
                //CriarNovoAluno();
                //CriarNovoAlunoComTelefone();
                //CriarNovoAlunoCom3Telefone3();
                //AtualizarDados();
                //NormalizarDadosDosAlunos();
                //ApagarOPedro();
                //ApagarAMarta();
            }

            System.IO.File.WriteAllText($@"c:\temp\profile.txt", profiler.RenderPlainText());
            Console.WriteLine("Terminei");
            Console.ReadLine();
        }

        private static void ImprimirSeparador()
        {
            Console.WriteLine("------------------------------------------------");
        }

        #region Consulta
        private static void ObterTodosOsAlunos()
        {
            var escola = new EscolaDBEntities();
            var listaAlunos = escola.Aluno.ToList();

            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
            }

            ImprimirSeparador();
        }

        private static void ObterTodosOsAlunosComIdade()
        {
            var escola = new EscolaDBEntities();
            var listaAlunos = escola.Aluno.ToList();

            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome} - Idade: {aluno.Idade}");
            }

            ImprimirSeparador();
        }

        private static void ObterTodosOsAlunosQueComecemCom(string inicio)
        {
            var escola = new EscolaDBEntities();
            var listaAlunos = escola.Aluno.Where(x => x.Nome.StartsWith(inicio)).ToList();

            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
            }

            ImprimirSeparador();
        }

        private static void ObterTodosOsAlunosQuePossuemTelefone()
        {
            var escola = new EscolaDBEntities();
            var listaAlunos = escola.Aluno.Where(x => x.Telefone.ToList().Any()).ToList();

            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
            }

            ImprimirSeparador();
        }
        #endregion Consulta

        #region Insercao
        private static void CriarNovoAluno()
        {
            var lucas = new Aluno
            {
                Nome = "Lucas da Silva",
                Matricula = "0001239",
                Sexo = "M",
                DataNascimento = new DateTime(2009, 01, 15),
                DataMatricula = DateTime.Today
            };

            var escola = new EscolaDBEntities();
            escola.Aluno.Add(lucas);
            escola.SaveChanges();
        }

        private static void CriarNovoAlunoComTelefone()
        {
            var maria = new Aluno
            {
                Nome = "Maria da Silva",
                Matricula = "0001240",
                Sexo = "F",
                DataNascimento = new DateTime(2009, 01, 15),
                DataMatricula = DateTime.Today
            };

            var telefones = new List<Telefone> {
                new Telefone
                {
                    NumeroTelefone = "123456789",
                    Prefixo = "351"
                }
            };
            maria.Telefone = telefones;

            var escola = new EscolaDBEntities();
            escola.Aluno.Add(maria);
            escola.SaveChanges();
        }

        private static void CriarNovoAlunoCom3Telefone3()
        {
            var maria = new Aluno
            {
                Nome = "Marta da Silva",
                Matricula = "0001240",
                Sexo = "F",
                DataNascimento = new DateTime(2009, 01, 15),
                DataMatricula = DateTime.Today
            };

            var telefones = new List<Telefone> {
                new Telefone
                {
                    NumeroTelefone = "123456789",
                    Prefixo = "351"
                },
                new Telefone
                {
                    NumeroTelefone = "123456790",
                    Prefixo = "351"
                },
                new Telefone
                {
                    NumeroTelefone = "123456791",
                    Prefixo = "351"
                },
            };
            maria.Telefone = telefones;

            var escola = new EscolaDBEntities();
            escola.Aluno.Add(maria);
            escola.SaveChanges();
        }
        #endregion Insercao

        #region Atualizacao
        private static void AtualizarDados()
        {
            var id = 2;
            var escola = new EscolaDBEntities();
            var pedro = escola.Aluno.FirstOrDefault(x => x.Id == id);
            pedro.Nome = "Pedro de Sousa";
            escola.SaveChanges();
        }


        private static void NormalizarDadosDosAlunos()
        {
            var escola = new EscolaDBEntities();
            var alunos = escola.Aluno.ToList();

            foreach (var aluno in alunos)
            {
                aluno.Nome = ConvertInicialMaiuscula(aluno.Nome);

                if (aluno.DataMatricula == null)
                {
                    aluno.DataMatricula = DateTime.Today;
                }
            }

            escola.SaveChanges();
        }


        public static string ConvertInicialMaiuscula(string palavra)
        {
            var primeiraLetra = palavra[0].ToString().ToUpper();
            var restoPalavra = palavra.Substring(1, palavra.Length - 1);
            var resultado = primeiraLetra + restoPalavra;

            return resultado;
        }
        #endregion Atualizacao

        #region ApagarDados
        private static void ApagarOPedro()
        {
            var id = 2;
            var escola = new EscolaDBEntities();
            var pedro = escola.Aluno.FirstOrDefault(x => x.Id == id);
            escola.Aluno.Remove(pedro);

            escola.SaveChanges();
        }



        private static void ApagarAMarta()
        {
            var id = 8;
            var escola = new EscolaDBEntities();
            var marta = escola.Aluno.FirstOrDefault(x => x.Id == id);
            escola.Telefone.RemoveRange(marta.Telefone); //Se eu não configurar o UpdateCascade no Database
            escola.Aluno.Remove(marta);
            

            escola.SaveChanges();
        }
        #endregion ApagarDados

    }
}

//CRUD
//AtualizarModelo
//Profiling
//TOSTRING

