using System.Threading.Tasks;
using Activities.Domain.Entities;
using Activities.Service.User;
using Microsoft.AspNetCore.Mvc;

namespace Activities.Controllers
{
    public class UserController : BaseController
    {
        public UserController()
        {
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(Login.Query query)
        {
            return await Mediator.Send(query);
        }
    }
}
