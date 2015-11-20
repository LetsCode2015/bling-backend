using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;

namespace BlingBackend.Web.Controllers
{
    public class ReminderController : BaseController
    {
        private readonly IReminderLogic _logic;

        public ReminderController(IReminderLogic logic) 
        {
            _logic = logic;
        }

        [HttpGet]
        public List<Reminder> GetAll()
        {
            return _logic.GetAll()
                .ToList();
        }

        [HttpPost]
        public int Create(Reminder item)
        {
            return _logic.Create(item);
        }

        [HttpGet]
        public Reminder Get(int id)
        {
            return _logic.Get(id);
        }

        [HttpPost]
        public void Update(Reminder item)
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