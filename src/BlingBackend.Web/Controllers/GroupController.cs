using BlingBackend.Logic.Interfaces;

namespace BlingBackend.Web.Controllers
{
    public class GroupController : BaseController
    {
        private readonly IGroupLogic _logic;

        public GroupController(IGroupLogic logic) 
        {
            _logic = logic;
        }
    }
}