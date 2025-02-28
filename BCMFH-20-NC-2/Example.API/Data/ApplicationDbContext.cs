using Example.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.API.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Todos> Todos { get; set; }

    }
}
