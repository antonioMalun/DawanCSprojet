using Ecome.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecome.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivreUser>().HasKey(lu => new { lu.UserId, lu.LivreId });
            modelBuilder.Entity<FilmUser>().HasKey(fu => new { fu.UserId, fu.FilmId });
            modelBuilder.Entity<FilmActeur>().HasKey(fa => new { fa.ActeurId, fa.FilmId });
            modelBuilder.Entity<FilmUser>().HasKey(fu => new { fu.UserId, fu.FilmId });



        }




        public DbSet<Film> Films { get; set; }
        public DbSet<Livre> Livres { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<FilmUser> FilmUsers { get; set; }
        public DbSet<LivreUser> LivreUsers { get; set; }
        public DbSet<LivreAuteur> LivreAuteurs { get; set; }
        public DbSet<FilmActeur> FilmActeurs { get; set; }

    }
}
