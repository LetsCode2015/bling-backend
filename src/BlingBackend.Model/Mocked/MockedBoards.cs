using System.Collections.Generic;

namespace BlingBackend.Model.Mocked
{
    public static class MockedBoards
    {
        public static Board HomeBoard = new Board
        {
            Name = "Home project",
            Description = "lorem ipsum...",
            Tasks = null
        };

        public static Board PartyBoard = new Board
        {
            Name = "Party board",
            Description = "lorem ipsum...",
            Tasks = new List<Task>
            {
                MockedTasks.BuyBeer,
                MockedTasks.InviteFriends
            }
        };
    }
}