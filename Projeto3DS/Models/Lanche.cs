using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto3DS.Models
{
<<<<<<< HEAD

    [Table("Lanche")] // Criação de nome de tabela
    public class Lanche
    {
        [StringLength(200, MinimumLength = 20)]
        public string Descrisaocurta { get; set; }
        public string Descrisaodetalhada { get; set; }

        public Boolean Emestoque { get; set; }

        [Key] //Chave primária
        public int Lancheid { get; set; }

        [StringLength(80, MinimumLength = 10, ErrorMessage = "Tamanho inválido")] //StringLenght = Tamanho máximo, minimumlenght
        [Required(ErrorMessage = "Por favor coloca o nome.")]   // Required = Obrigatório                    
        [Display(Name = "Nome do Lanche")] // Display = Mostrar
        public string Nome { get; set; }

        [Range(1,999.99)] //Limite de preço
        [Column(TypeName = "decimal(10,2)")] //Nome da coluna e os atributos
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public string ImagemULR { get; set; }

        public string Lanchepreferido { get; set; }

        public string Imagemiminiauta { get; set; }

        public int Categoriaid { get; set; }

        public virtual Categoria Categoria { get; set;}
=======
   
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
>>>>>>> bb4a8462de800b048633786314d726753607ea8f







    }
}
