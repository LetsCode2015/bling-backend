using System.Linq;
using BlingBackend.Model;

namespace BlingBackend.Logic.Interfaces
{
    public interface IBoardLogic : ILogic<Board>
    {
        IQueryable<Board> GetMy();
        IQueryable<Board> GetFav();
    }
}