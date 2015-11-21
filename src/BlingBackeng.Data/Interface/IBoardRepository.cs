using System.Linq;
using BlingBackend.Model;

namespace BlingBackeng.Data.Interface
{
    public interface IBoardRepository : IRepository<Board>
    {
        IQueryable<Board> GetMy();
        IQueryable<Board> GetFav();
    }
}