using Casgem_JWT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        
        [HttpGet("[Action]")]
        public IActionResult Login()
        {

            return Created("", new BuildToken().CreateToken());
        }
        [Authorize]
        [HttpGet("[Action]")]
        public IActionResult CustomerList()
        {

            return Ok("Müşteri Listesine Eriştiniz");
        }
    }
}
