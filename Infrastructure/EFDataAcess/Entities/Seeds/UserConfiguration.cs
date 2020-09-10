using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EFDataAcess.Entities.Seeds
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
            new User
            {
                UserId = 1,
                UserName = "agent",
                Password = "agent",
                FirstName = "Agent",
                LastName = "Agent",
                Role = Role.AGENT
            },

            new User
            {
                UserId = 2,
                UserName = "admin",
                Password = "admin",
                FirstName = "Admin",
                LastName = "Admin",
                Role = Role.ADMINISTRATOR
            }
            );
        }
    }
}
