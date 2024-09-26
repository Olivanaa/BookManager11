using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManager11.Models
{
    
    
       [Table("Tb_Livro")]
        public class Livro
        {
            [Column("Id"), HiddenInput]
            public int Id { get; set; }
            public required string Titulo { get; set; }
            public required string Autor { get; set; }
            public required string Genero { get; set; }

            public DateTime DataPublicacao { get; set; }
        }

    
}
