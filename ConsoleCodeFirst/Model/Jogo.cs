using System;
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

        //[MaxLength(50)]
        //[Column("Category")]
        //public string TipoJogo { get; set; }

        //ChaveCandidata
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Position")]
        public int Posicao { get; set; }

        public virtual Plataforma Plataforma { get; set; }
        public virtual Categoria Categoria { get; set; }



        //[Timestamp]
        //public byte[] RowVersion { get; set; }

        //[Phone]
        //[EmailAddress]
        //public string Telefone { get; set; } //.com, @ ...


        //[Column("ReleaseDate")]
        //public DateTime DataLancamento { get; set; }
    }
}