using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.EFDataAcess.Entities
{
    public class Information
    {
        [Key]
        [Column("information_id")]
        public int InformationId { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("adress")]
        public string Adress { get; set; }
        [Column("phone_number")]
        public string Phone { get; set; }
        [Column("martial_status")]
        public string MartialStatus { get; set; }
        [Column("birthdata")]
        public DateTime Birthdate { get; set; }
        [Column("gender")]
        public string Gender { get; set; }

        [ForeignKey("User")]
        public int UserFK { get; set; }
        public virtual User User { get; set; }
    }
}
