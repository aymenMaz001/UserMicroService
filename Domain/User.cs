using Domain.Enum;
using System;

namespace Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public DateTime c_user { get; set; }
        public Information Information { get; set; }
        public User()
        {
                
        }

        public User(int userId, string userName, string password, Role role, DateTime c_user, Information information)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            Role = role;
            this.c_user = c_user;
            Information = information;
        }
    }
}
