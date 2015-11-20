using System.Collections.Generic;

namespace BlingBackend.Model.Mocked
{
    public static class MockedBoards
    {
        public static Board HomeBoard = new Board
        {
            Name = "Home project",
            Tasks = null
        };

        public static Board PartyBoard = new Board
        {
            Name = "Party board",
            Tasks = new List<Task>
            {
                MockedTasks.BuyBeer,
                MockedTasks.InviteFriends
            }
        };
    }
}