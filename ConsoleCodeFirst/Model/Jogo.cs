using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleCodeFirst.Model
{
    [Table("Games")]
    public class Jogo
    {
        //Chave Primaria
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [MaxLength(255, ErrorMessage = "Nome grande demais")]
        [MinLength(10)]
        [Column("Name")]
        public string Nome { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Position")]
        public int? Posicao { get; set; }

        public virtual Plataforma Plataforma { get; set; }
        

        [Column("ReleaseDate")]
        public DateTime? DataLancamento { get; set; }

        public bool Finalizado { get; set; }


        public virtual List<Categoria> Categoria { get; set; }
    }
}