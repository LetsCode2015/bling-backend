using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;

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
        public List<Board> GetAll()
        {
            return _logic.GetAll()
                .ToList();
        }

        [HttpPost]
        public int Create(Board item)
        {
            return _logic.Create(item);
        }

        [HttpGet]
        public Board Get(int id)
        {
            return _logic.Get(id);
        }

        [HttpPost]
        public void Update(Board item)
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