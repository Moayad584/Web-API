using Library.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UseresController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        public UseresController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public async Task<ActionResult> GetData()
        {
            return Ok(await _userRepo.GetData());
        }
    }
}
