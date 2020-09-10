using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserMicroService.UseCases.GetUserById
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetUserByIdController : ControllerBase
    {
        private readonly IUserReadOnlyRepository _userReadOnlyRepository;

        public GetUserByIdController(IUserReadOnlyRepository userReadOnlyRepository)
        {
            _userReadOnlyRepository = userReadOnlyRepository;
        }


        // GET api/GetUserByIdController/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeeById(int id)
        {
            return Ok(_userReadOnlyRepository.Get(id).Result);
        }
    }
}
