using BlingBackend.Logic.Interfaces;

namespace BlingBackend.Web.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryLogic _logic;

        public CategoryController(ICategoryLogic logic) 
        {
            _logic = logic;
        }
    }
}