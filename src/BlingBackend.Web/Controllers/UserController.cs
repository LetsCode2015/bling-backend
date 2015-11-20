using System.Collections.Generic;
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
        public void Signup(User item)
        {
             _logic.Signup(item);
        }

        [HttpGet]
        public List<User> GetAll()
        {
            return _logic.GetAll()
                .ToList();
        }

        [HttpPost]
        public int Create(User item)
        {
            return _logic.Create(item);
        }

        [HttpGet]
        public User Get(int id)
        {
            return _logic.Get(id);
        }

        [HttpPost]
        public void Update(User item)
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