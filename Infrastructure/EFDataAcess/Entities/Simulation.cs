using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.EFDataAcess.Entities
{
    public class Simulation
    {
        [Key]
        public int SimulationId { get; set; }
        [Column("agent_id")]
        public int AgentId { get; set; }
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("client_id")]
        public int ClientId { get; set; }
        [ForeignKey("User")]
        public int User_fk { get; set; }
        public virtual User User{ get; set; }
    }
}
