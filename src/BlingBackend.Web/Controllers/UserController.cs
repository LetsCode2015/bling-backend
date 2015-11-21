using System.Linq;
using System.Web.Mvc;
using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;

namespace BlingBackend.Web.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserLogic _logic;

        public UserController(IUserLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public ActionResult Signup(User item)
        {
            return Json(_logic.Signup(item), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Json(_logic.GetAll().ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(User item)
        {
            return Json(_logic.Create(item));
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            return Json(_logic.Get(id), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Update(User item)
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