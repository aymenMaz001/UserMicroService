using Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserMicroService.UseCases.Authentification
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        private readonly IUserReadOnlyRepository _userReadOnlyRepository;

        public AuthentificationController(IUserReadOnlyRepository userReadOnlyRepository)
        {
            _userReadOnlyRepository = userReadOnlyRepository;
        }

        // POST api/<Authentification>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AuthParameters authParameters)
        {
            var result = _userReadOnlyRepository.Authentification(authParameters.UserName, authParameters.Password).Result;
            if (result == null)
                return NotFound();
            return Ok(result);
        }

    }
}
