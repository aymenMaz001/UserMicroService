using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserMicroService.UseCases.DeleteInformation
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteInformationController : ControllerBase
    {
        private readonly IUserWriteOnlyRepository _userWriteOnlyRepository;

        public DeleteInformationController(IUserWriteOnlyRepository userWriteOnlyRepository)
        {
            _userWriteOnlyRepository = userWriteOnlyRepository;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return Ok(_userWriteOnlyRepository.DeleteInformation(id).Result);
        }
    }
}
