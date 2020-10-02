using System.Threading.Tasks;
using Application.Repositories;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace UserMicroService.UseCases.UpdateInformation
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateInformationController : ControllerBase
    {
        private readonly IUserWriteOnlyRepository _userWriteOnlyRepository;

        public UpdateInformationController(IUserWriteOnlyRepository userWriteOnlyRepository)
        {
            _userWriteOnlyRepository = userWriteOnlyRepository;
        }

        // PUT: api/test/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Information information)
        {
            return Ok(_userWriteOnlyRepository.UpdateInformation(id, information).Result);

        }
    }
}
