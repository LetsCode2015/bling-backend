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
        public ActionResult GetAll()
        {
            return Json(_logic.GetAll().ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(Group item)
        {
            return Json(_logic.Create(item));
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            return Json(_logic.Get(id), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Update(Group item)
        {
            return Json(_logic.Update(item));
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            return Json(_logic.Delete(id));
        }
    }
}