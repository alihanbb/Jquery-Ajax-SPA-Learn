using Microsoft.EntityFrameworkCore;

namespace Spa.App.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Books> Books { get; set; } 

    }
}
