using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                Email = "agent@agent.com",
                Phone = "22-222-222",
                Adress = "46 Titchfield St. Liverpool L5 8UT, UNITED KINGDOM",
                UserFK = 1
            },
            new Information
            {
                InformationId = 2,
                Email = "agent@agent.com",
                Phone = "22-222-222",
                Adress = "46 Titchfield St. Liverpool L5 8UT, UNITED KINGDOM",
                UserFK = 2
            }
            );
        }
    }
}
