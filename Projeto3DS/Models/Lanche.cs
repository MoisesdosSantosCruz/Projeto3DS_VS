using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto3DS.Models
{
   
    [Table ("Lanche")]
    public class Lanche
    {
        public string descrisaocurta { get; set; }
        public string descrisaodetalhada { get; set; }
        
        [Key] //
        public int lancheid { get; set;}

        public string nome { get; set; }
        public decimal preco { get; set; }

        public string imagemULR { get; set; }

        public string lanchepreferido { get; set; }

        public string imagemiminiauta { get; set; }

        public int categoriaid {get; set;}

        public string categoria {get; set; }







    }
}
