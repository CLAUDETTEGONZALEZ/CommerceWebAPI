using APIService.IService;
using APIService.Service;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IUserService _userService;
        public UserController(ILogger<ProductController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost(Name = "InsertUser")]
        public int Post([FromBody] UserItem userItem)
        {
            return _userService.InsertUser(userItem);
        }
        [HttpGet(Name = "GetAllUsers")]
        public List<UserItem> GetAll()
        {
            return _userService.GetAllUsers();
        }
        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromBody] UserItem userItem)
        {
            _userService.UpdateUser(userItem);
        }
        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromQuery] int id)
        {
            _userService.DeleteUser(id);
        }
    }
}
