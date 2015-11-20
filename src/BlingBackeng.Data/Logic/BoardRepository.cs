using BlingBackend.Model;
using BlingBackeng.Data.Interface;
using System;
using System.Linq;

namespace BlingBackeng.Data.Logic
{
    public sealed class BoardRepository : IBoardRepository
    {
        public IQueryable<Board> GetBoards()
        {
            throw new NotImplementedException();
        }
    }
}