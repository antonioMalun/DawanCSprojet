using Microsoft.EntityFrameworkCore;

namespace Ecome.Models
{
    public class EcomeContext:DbContext
    {
        public EcomeContext(DbContextOptions<EcomeContext> options) :base(options)
        {

        }

        public DbSet<Film> Films{ get; set; }
        public DbSet<Livre> Livres { get; set; }



    }
}
