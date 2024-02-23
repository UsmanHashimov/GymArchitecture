using GymArchitecture.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace GymArchitecture.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<Gym> Gyms { get; set; }
    }
}
