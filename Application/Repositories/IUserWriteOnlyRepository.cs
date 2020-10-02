using Domain;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IUserWriteOnlyRepository
    {
        Task<User> Add(User user);
        Task<User> Update(int id, User user);
        Task<User> Delete(int id);

        Task<Information> AddInformation(Information information);
        Task<Information> UpdateInformation(int id, Information information);
        Task<Information> DeleteInformation(int id);
    }
}
