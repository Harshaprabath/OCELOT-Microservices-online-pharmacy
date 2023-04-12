using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.User.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        // GET: api/<SupplierController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetUsers());
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            return _userService.GetUser(id) != null ? Ok(_userService.GetUser(id)) : NoContent();

        }
    }
}
