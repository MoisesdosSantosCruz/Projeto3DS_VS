<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto3DS.Models
{
    [Table("Categoria")] // Criação de nome de tabela
    public class Categoria
    {
        [Key] //Chave primária
        public int Categoriaid { get; set; }

        [StringLength(100, ErrorMessage = "Tamanho inválido")] 
        [Required(ErrorMessage = "Por favor coloca o nome.")]
        [Display(Name = "Nome da Categoria")] // Display = Mostrar
        public string CategoriaNome { get; set; }

        public string Descrisao {get; set;}

        public List <Lanche> Lanche { get; set; }


=======
﻿namespace Projeto3DS.Models
{
    public class Categoria
    {
        public int categoriaid { get; set; }

        public string categoria { get; set; }

        public string descrisao {get; set;}

        public string lanche { get; set; }
>>>>>>> bb4a8462de800b048633786314d726753607ea8f
    }
}
