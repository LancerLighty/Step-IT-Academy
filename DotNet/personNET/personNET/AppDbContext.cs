using Microsoft.EntityFrameworkCore;
using personNET.models;

namespace personNET
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }
        public DbSet<Person> persons { get; set; } 
        public DbSet<Nationality> Nationality { get; set; }
    }
}
