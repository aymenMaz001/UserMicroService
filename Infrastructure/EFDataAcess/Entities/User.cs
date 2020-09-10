using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.EFDataAcess.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Column("username")]
        public string UserName { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("role")]
        public Role Role { get; set; }
        public virtual Information Information { get; set; }
    }
}
