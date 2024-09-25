using BookManager11.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManager11.Persistencia
{
    public class LivroDbContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }



        public LivroDbContext(DbContextOptions<LivroDbContext> options) : base(options)
        {

        }

    }
}
