using BlingBackend.Model;

namespace BlingBackend.Logic.Interfaces
{
    public interface IUserLogic : ILogic<User>
    {
        bool Signup(User item);
    }
}