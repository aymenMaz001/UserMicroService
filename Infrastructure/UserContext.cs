using Infrastructure.EFDataAcess.Entities;
using Infrastructure.EFDataAcess.Entities.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Information> information { get; set; }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new InformationConfiguration());
    }
    }
}
