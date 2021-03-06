using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleCodeFirst.Model
{
    [Table("Plataforms")]
    public class Plataforma
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        [Column("Name")]
        public string Nome { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
