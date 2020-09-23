using System.Threading.Tasks;
using Application.Repositories;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace UserMicroService.UseCases.UpdateUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateUserController : ControllerBase
    {
        private readonly IUserWriteOnlyRepository _userWriteOnlyRepository;

        public UpdateUserController(IUserWriteOnlyRepository userWriteOnlyRepository)
        {
            _userWriteOnlyRepository = userWriteOnlyRepository;
        }

        // PUT: api/test/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, User user)
        {
            return Ok(_userWriteOnlyRepository.Update(id, user).Result);

        }
    }
}
