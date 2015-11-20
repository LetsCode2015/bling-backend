using BlingBackend.Model;
using BlingBackeng.Data.Interface;
using System.Collections.Generic;
using System.Linq;

namespace BlingBackeng.Data.Logic
{
    public class BoardRepositoryMocked : IBoardRepository
    {
        public IQueryable<Board> GetBoards()
        {
            return new List<Board>
            {
                new Board
                {
                    Id = 1,
                    Name = "Projekt Bartka",
                    Tasks = new List<Task>()
                },
                new Board
                {
                    Id = 2,
                    Name = "Projekt Mateusza",
                    Tasks = new List<Task>()
                },
                new Board
                {
                    Id = 3,
                    Name = "Projekt Patryka",
                    Tasks = new List<Task>()
                },
                new Board
                {
                    Id = 4,
                    Name = "Projekt Piotrka",
                    Tasks = new List<Task>()
                },
            }.AsQueryable();
        }
    }
}