using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleCodeFirst.Model
{
    [Table("Players")]
    public class Jogador
    {
        public Guid JogadorId { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public virtual List<Progresso> Historico { get; set; } //save state 


        [NotMapped]
        public int Idade => DateTime.Today.Year - DataNascimento.Value.Year;
    }
}