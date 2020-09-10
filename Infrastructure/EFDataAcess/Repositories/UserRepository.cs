using Application.Repositories;
using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.EFDataAcess.Repositories
{
    public class UserRepository : IUserReadOnlyRepository
    {
        private readonly UserContext _context;
        private readonly IMapper _mapper;

        public UserRepository(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<User> Authentification(string userName, string password)
        {
            var user = await _context.users
                .Include(t => t.Information)
                ?.FirstOrDefaultAsync(u => u.UserName.Equals(userName) && u.Password.Equals(password));
            if (user == null)
                return null;
            User UserDTO = _mapper.Map<User>(user);
            return UserDTO;
        }

        public async Task<User> Get(int id)
        {
            var user = await _context.users
                .Include(t => t.Information)
                .FirstOrDefaultAsync(u => u.UserId == id);

            User UserDTO = _mapper.Map<User>(user);
            return UserDTO;
        }

        public async Task<List<User>> GetAll()
        {
            var user = await _context.users
                .Include(t => t.Information)
                .ToListAsync();

            List<User> UserDTO = _mapper.Map<List<User>>(user);
            return UserDTO;
        }
    }
}
