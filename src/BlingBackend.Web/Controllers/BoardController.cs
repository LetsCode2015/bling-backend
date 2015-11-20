using BlingBackend.Logic.Interfaces;

namespace BlingBackend.Web.Controllers
{
    public class BoardController : BaseController
    {
        private readonly IBoardLogic _logic;

        public BoardController(IBoardLogic logic) 
        {
            _logic = logic;
        }
    }
}