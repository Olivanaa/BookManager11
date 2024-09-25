using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManager11.Models
{
    
    
       [Table("Tb_Livro")]
        public class Livro
        {
            [Column("Id"), HiddenInput]
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string Genero { get; set; }

            public DateTime DataPublicacao { get; set; }
        }

    
}
