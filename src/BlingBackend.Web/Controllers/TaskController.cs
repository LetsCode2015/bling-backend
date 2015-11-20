using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;

namespace BlingBackend.Web.Controllers
{
    public class TaskController : BaseController
    {
        private readonly ITaskLogic _logic;

        public TaskController(ITaskLogic logic) 
        {
            _logic = logic;
        }

        [HttpGet]
        public List<Task> GetAll()
        {
            return _logic.GetAll()
                .ToList();
        }

        [HttpPost]
        public int Create(Task item)
        {
            return _logic.Create(item);
        }

        [HttpGet]
        public Task Get(int id)
        {
            return _logic.Get(id);
        }

        [HttpPost]
        public void Update(Task item)
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