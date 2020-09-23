using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EFDataAcess.Entities.Seeds
{
    public class SimulationConfiguration: IEntityTypeConfiguration<Simulation>
    {
        public void Configure(EntityTypeBuilder<Simulation> builder)
        {
            builder.HasData(
            new Simulation
            {
                SimulationId = 1,
                AgentId = 1,
                ClientId = 1,
                ProductId = 1,
                User_fk = 1
            },
            new Simulation
            {
                SimulationId = 2,
                AgentId = 1,
                ClientId = 1,
                ProductId = 1,
                User_fk = 1
            },
            new Simulation
            {
                SimulationId = 3,
                AgentId = 1,
                ClientId = 1,
                ProductId = 1,
                User_fk = 1
            },
            new Simulation
            {
                SimulationId = 4,
                AgentId = 1,
                ClientId = 1,
                ProductId = 1,
                User_fk = 3
            },
            new Simulation
            {
                SimulationId = 5,
                AgentId = 1,
                ClientId = 1,
                ProductId = 1,
                User_fk = 1
            },
            new Simulation
            {
                SimulationId = 6,
                AgentId = 1,
                ClientId = 1,
                ProductId = 1,
                User_fk = 3
            }

            );
        }
    }
}
