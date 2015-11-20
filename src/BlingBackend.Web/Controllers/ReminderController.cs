using BlingBackend.Logic.Interfaces;

namespace BlingBackend.Web.Controllers
{
    public class ReminderController : BaseController
    {
        private readonly IReminderLogic _logic;

        public ReminderController(IReminderLogic logic) 
        {
            _logic = logic;
        }
    }
}