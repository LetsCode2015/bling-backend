﻿using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;
using System.Linq;
using System.Web.Mvc;

namespace BlingBackend.Web.Controllers
{
    public class BoardController : BaseController
    {
        private readonly IBoardLogic _logic;

        public BoardController(IBoardLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Json(_logic.GetAll().ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetMy()
        {
            return Json(_logic.GetMy().ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetFav()
        {
            return Json(_logic.GetFav().ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(Board item)
        {
            return Json(_logic.Create(item));
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            return Json(_logic.Get(id), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Update(Board item)
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