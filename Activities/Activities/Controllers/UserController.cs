using System.Threading.Tasks;
using Activities.Service.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Activities.Controllers
{
    [AllowAnonymous]
    public class UserController : BaseController
    {

        #region Login
        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(Login.Query query)
        {
            return await Mediator.Send(query);
        }
        #endregion
    }
}
