using System.Threading.Tasks;
using Application.Repositories;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace UserMicroService.UseCases.AddInformation
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddInformationController : ControllerBase
    {
        private readonly IUserWriteOnlyRepository _userWriteOnlyRepository;

        public AddInformationController(IUserWriteOnlyRepository userWriteOnlyRepository)
        {
            _userWriteOnlyRepository = userWriteOnlyRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Information information)
        {
            return Ok(_userWriteOnlyRepository.AddInformation(information).Result);
        }
    }
}
