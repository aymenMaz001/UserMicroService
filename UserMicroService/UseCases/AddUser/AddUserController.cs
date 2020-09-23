using System.Threading.Tasks;
using Application.Repositories;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace UserMicroService.UseCases.AddUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddUserController : ControllerBase
    {
        private readonly IUserWriteOnlyRepository _userWriteOnlyRepository;

        public AddUserController(IUserWriteOnlyRepository userWriteOnlyRepository)
        {
            _userWriteOnlyRepository = userWriteOnlyRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            return Ok(_userWriteOnlyRepository.Add(user).Result);
        }
    }
}
