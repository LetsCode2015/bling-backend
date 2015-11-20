using BlingBackend.Logic.Interfaces;

namespace BlingBackend.Web.Controllers
{
    public class TaskController : BaseController
    {
        private readonly ITaskLogic _logic;

        public TaskController(ITaskLogic logic) 
        {
            _logic = logic;
        }
    }
}