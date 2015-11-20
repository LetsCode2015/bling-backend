using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;

namespace BlingBackend.Web.Controllers
{
    public class GroupController : BaseController
    {
        private readonly IGroupLogic _logic;

        public GroupController(IGroupLogic logic) 
        {
            _logic = logic;
        }

        [HttpGet]
        public List<Group> GetAll()
        {
            return _logic.GetAll()
                .ToList();
        }

        [HttpPost]
        public int Create(Group item)
        {
            return _logic.Create(item);
        }

        [HttpGet]
        public Group Get(int id)
        {
            return _logic.Get(id);
        }

        [HttpPost]
        public void Update(Group item)
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