using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackend.Logic
{
    public class BoardLogic : LogicBase<Board>, IBoardLogic
    {
        private readonly IBoardRepository _boardRepository;

        public BoardLogic(IBoardRepository boardRepository) 
            : base(boardRepository)
        {
            _boardRepository = boardRepository;
        }
    }
}