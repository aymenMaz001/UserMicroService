using System.Threading.Tasks;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace UserMicroService.UseCases.DeleteUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteUserController : ControllerBase
    {
        private readonly IUserWriteOnlyRepository _userWriteOnlyRepository;

        public DeleteUserController(IUserWriteOnlyRepository userWriteOnlyRepository)
        {
            _userWriteOnlyRepository = userWriteOnlyRepository;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return Ok(_userWriteOnlyRepository.Delete(id).Result);
        }
    }
}
