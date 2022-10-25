using Microsoft.EntityFrameworkCore;
//importar entidades 

namespace Trabajo2Web.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

       // public DbSet<Genero> Generos { get; set; }

    }
}
