using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackend.Logic
{
    public class UserLogic : LogicBase<User>, IUserLogic
    {
        private readonly IUserRepository _userRepository;

        public UserLogic(IUserRepository userRepository) 
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Signup(User item)
        {
            _userRepository.Create(item);
            return true;
        }
    }
}