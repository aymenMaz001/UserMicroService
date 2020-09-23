using System;

namespace Domain
{
    public class Information
    {
        public int InformationId { get; set; }

        public string Email { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MartialStatus { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public int UserFK { get; set; }

    }
}
