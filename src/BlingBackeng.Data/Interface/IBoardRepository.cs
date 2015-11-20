using BlingBackend.Model;
using System.Linq;

namespace BlingBackeng.Data.Interface
{
    public interface IBoardRepository
    {
        IQueryable<Board> GetBoards();
    }
}