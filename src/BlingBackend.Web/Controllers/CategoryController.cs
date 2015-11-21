using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BlingBackend.Web.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryLogic _logic;

        public CategoryController(ICategoryLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public List<Category> GetAll()
        {
            return _logic.GetAll()
                .ToList();
        }

        [HttpPost]
        public int Create(Category item)
        {
            return _logic.Create(item);
        }

        [HttpGet]
        public Category Get(int id)
        {
            return _logic.Get(id);
        }

        [HttpPost]
        public void Update(Category item)
        {
            _logic.Update(item);
        }

        [HttpPost]
        public void Delete(int id)
        {
            _logic.Delete(id);
        }
    }
}