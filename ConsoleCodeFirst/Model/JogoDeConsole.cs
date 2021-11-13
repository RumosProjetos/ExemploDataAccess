using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst.Model
{
    [Table("ConsoleGame")]
    public class JogoDeConsole : Jogo
    {
        public bool MidiaFisica { get; set; }
        public string CaminhoFoto { get; set; }
    }
}
