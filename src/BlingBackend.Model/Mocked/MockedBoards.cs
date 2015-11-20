using System.Collections.Generic;

namespace BlingBackend.Model.Mocked
{
    public static class MockedBoards
    {
        public static Board HomeBoard = new Board
        {
            Id = 1,
            Name = "Home project",
            Tasks = new List<Task>
            {
                MockedTasks.BuyBeer,
                MockedTasks.WashDishes
            }
        };

        public static Board PartyBoard = new Board
        {
            Id = 2,
            Name = "Party board",
            Tasks = new List<Task>
            {
                MockedTasks.BuyBeer,
                MockedTasks.InviteFriends
            }
        };
    }
}