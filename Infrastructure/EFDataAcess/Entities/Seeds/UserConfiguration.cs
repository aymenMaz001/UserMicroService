using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
                c_user = new DateTime(2020, 02, 01),
                Role = Role.AGENT,
                
            },

            new User
            {
                UserId = 2,
                UserName = "admin",
                Password = "admin",
                c_user = new DateTime(2020,02,01),
                Role = Role.ADMINISTRATOR
            },

            new User
            {
                UserId = 3,
                UserName = "agent2",
                Password = "agent2",
                c_user = new DateTime(2020, 02, 01),
                Role = Role.AGENT
            },

            new User
            {
                UserId = 4,
                UserName = "agent3",
                Password = "agent3",
                c_user = new DateTime(2019, 02, 01),
                Role = Role.AGENT
            },

            new User
            {
                UserId = 5,
                UserName = "agent4",
                Password = "agent4",
                c_user = new DateTime(2020, 04, 01),
                Role = Role.AGENT
            }

            );
        }
    }
}
