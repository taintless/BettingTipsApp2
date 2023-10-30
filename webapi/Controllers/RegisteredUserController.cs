using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Db;
using webapi.Db.Entities;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisteredUserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RegisteredUserController(AppDbContext context)
        {
            this._context = context;
        }

        [HttpPost(Name = "AddUser")]
        public OkObjectResult Add([FromBody]AddUserResource user)
        {
            var newUser = new RegisteredUser { Email = user.Email, Id = Guid.NewGuid(), RegsisteredOn = DateTime.Now };
            _context.Add(newUser);
            _context.SaveChanges();
            return Ok(newUser);
        }

        [HttpGet(Name = "GetUser")]
        public OkObjectResult Get()
        {
            var users = _context.RegisteredUsers.Include(x => x.UserGames).Select(x => new GetUsersResource
            {
                Email = x.Email,
                Id = x.Id,
                UserGames = x.UserGames.Select(y => y.GameId).ToList()
            }).ToList();
            return Ok(users);
        }
    }
}
