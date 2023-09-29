using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Db;
using webapi.Db.Entities;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisteredUserController : ControllerBase
    {
        private readonly DbContext _context;

        public RegisteredUserController(DbContext context)
        {
            this._context = context;
        }

        [HttpPost(Name = "")]
        public OkObjectResult Add([FromBody]AddUserResource user)
        {
            var newUser = new RegisteredUser { Email = user.Email, Id = Guid.NewGuid() };
            _context.Add(newUser);
            _context.SaveChanges();
            return Ok(newUser);

        }
    }
}
