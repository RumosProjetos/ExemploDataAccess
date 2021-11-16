using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst.Model
{
    [Table("DownloadContents")]
    public class ConteudoBaixado
    {
        public Guid Id { get; set; }
        public Guid JogoId { get; set; }
        public string Descricao { get; set; }
    }
}
