using Microsoft.EntityFrameworkCore;
using ParkControl.Models;

namespace ParkControl.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}