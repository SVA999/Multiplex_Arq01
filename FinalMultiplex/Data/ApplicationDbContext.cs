using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using b_Multiplex.Clases;

namespace FinalMultiplex.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<b_Multiplex.Clases.Multiplex> Multiplex { get; set; } = default!;
        public DbSet<b_Multiplex.Clases.Pelicula> Pelicula { get; set; } = default!;
    }
}
