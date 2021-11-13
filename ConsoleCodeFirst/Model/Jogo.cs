using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleCodeFirst.Model
{
    public class Jogo
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoJogo { get; set; }
        public virtual Plataforma Plataforma { get; set; }
    }
}