using Ecome.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecome.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }
        public DbSet<Filme> Filmes { get; set; }
        //public DbSet<Categorie> Categories { get; set; }

        public DbSet<Livre> Livres { get; set; }

        
        public DbSet<Livre_Autheur> Livre_Autheurs { get; set; }

        public DbSet<Filme_Autheur> Filme_Autheurs { get; set; }


    }
}
