using System.Linq;
using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackeng.Data.Logic
{
    public class BoardRepository : RepositoryBase<Board>, IBoardRepository
    {
        public BoardRepository(BlingBackendDbContext dbContext)
            : base(dbContext)
        {
        }

        public IQueryable<Board> GetMy()
        {
            return _dbContext.Set<Board>();
        }

        public IQueryable<Board> GetFav()
        {
            return _dbContext.Set<Board>();
        }
    }
}