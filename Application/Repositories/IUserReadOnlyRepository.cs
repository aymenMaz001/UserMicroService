using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IUserReadOnlyRepository
    {
        Task<User> Get(int id);
        Task<List<User>> GetAll();
        Task<User> Authentification(string user, string password);
    }
}
