using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst.Model
{
    [Table("Progress")]
    public class Progresso
    {
        public Guid Id { get; set; }
        public float Percentual { get; set; }
        public DateTime JogadoEm { get; set; }
        public Jogador Jogador { get; set; }
    }
}
