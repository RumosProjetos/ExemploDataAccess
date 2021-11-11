using StackExchange.Profiling;
using System;
using System.IO;

namespace ConsoleDatabaseFirst
{
    public static class Logger
    {
        public static void Log(string mensagem)
        {
            try
            {
                mensagem = mensagem + Environment.NewLine + MiniProfiler.Current.RenderPlainText();
                var path = $@"c:\temp\{DateTime.Today:yyyyMMddHHmm}_ConsoleDatabaseFirst.log";
                File.AppendAllText(mensagem, path);
            }
            catch (Exception)
            {
                //Lazzyness .... to do something
            }
        }

        public static void ImprimirSeparador(string name)
        {
            Console.WriteLine($"Método: {name} executado");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
