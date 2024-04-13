using Gaolos.Application.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILoggedInUserService _loggedInUserService;

        public AccountController(ILoggedInUserService loggedInUserService)
        {
            _loggedInUserService = loggedInUserService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_loggedInUserService.UserId);
        }
    }
}
