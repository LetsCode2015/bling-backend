using BlingBackend.Logic.Interfaces;

namespace BlingBackend.Web.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserLogic _logic;

        public UserController(IUserLogic logic)
        {
            _logic = logic;
        }
    }
}