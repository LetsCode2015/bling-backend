using BlingBackend.Model;

namespace BlingBackend.Logic.Interfaces
{
    public interface IUserLogic : ILogic<User>
    {
        void Signup(User item);
    }
}