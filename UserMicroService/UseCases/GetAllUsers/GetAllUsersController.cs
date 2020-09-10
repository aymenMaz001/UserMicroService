using System.Threading.Tasks;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserMicroService.UseCases.GetAllUsers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllUsersController : ControllerBase
    {
        private readonly IUserReadOnlyRepository _userReadOnlyRepository;

        public GetAllUsersController(IUserReadOnlyRepository userReadOnlyRepository)
        {
            _userReadOnlyRepository = userReadOnlyRepository;
        }


        // GET api/GetUserByIdController/5
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_userReadOnlyRepository.GetAll().Result);
        }
    }
}
