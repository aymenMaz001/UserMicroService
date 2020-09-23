using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.EFDataAcess.Entities.Seeds
{
    public class InformationConfiguration : IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> builder)
        {
            builder.HasData(
            new Information
            {
                InformationId = 1,
                FirstName = "Agent",
                LastName = "Agent",
                Gender = "Male",
                MartialStatus = "Single",
                Birthdate = new DateTime(1986, 06, 03),
                Email = "agent@agent.com",
                Phone = "22-222-222",
                Adress = "43 St. Tunis, Tunisa",
                UserFK = 1
            },
            new Information
            {
                InformationId = 2,
                FirstName = "Admin",
                LastName = "Admin",
                Gender = "Male",
                MartialStatus = "Married",
                Email = "admin@admin.com",
                Birthdate = new DateTime(1977, 08, 03),
                Phone = "22-666-777",
                Adress = "46  St. Tunis, Tunisia",
                UserFK = 2
            },
            new Information
            {
                InformationId = 3,
                FirstName = "Agent2",
                LastName = "Agent2",
                Gender = "Female",
                MartialStatus = "Married",
                Email = "admin@admin.com",
                Birthdate = new DateTime(1990, 12, 24),
                Phone = "22-444-222",
                Adress = "24  St. Tunis, Tunisia",
                UserFK = 3
            },
            new Information
            {
                InformationId = 4,
                FirstName = "Agent3",
                LastName = "Agent3",
                Gender = "Male",
                MartialStatus = "Married",
                Email = "agent4@agent.com",
                Birthdate = new DateTime(1977, 08, 03),
                Phone = "97-222-333",
                Adress = "27 St. Tunis , Tunisia",
                UserFK = 4
            },
            new Information
            {
                InformationId = 5,
                FirstName = "Agent4",
                LastName = "Agent4",
                Gender = "Female",
                MartialStatus = "Single",
                Email = "agent4@agent.com",
                Birthdate = new DateTime(1992, 08, 03),
                Phone = "22-222-222",
                Adress = "22 St. Tunis , Tunisia",
                UserFK = 5
            }
            ); 
        }
    }
}
