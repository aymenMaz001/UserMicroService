using Domain.Enum;

namespace Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public Information Information { get; set; }
        public User()
        {
                
        }

        public User(int userId, string userName, string password, string firstName, string lastName, Role role, Information information)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Information = information;
        }
    }
}
