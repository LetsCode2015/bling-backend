using System;
using System.Linq;
using System.Linq.Expressions;

namespace BlingBackeng.Data.Interface
{
    public interface IBoardRepository
    {
        IQueryable<Board> GetBoards(Expression<Func<Board, bool>> predicate);
    }
}