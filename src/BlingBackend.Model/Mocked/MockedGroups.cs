using System.Collections.Generic;

namespace BlingBackend.Model.Mocked
{
    public static class MockedGroups
    {
        public static Group HomeGroup = new Group
        {
            Id = 1,
            Name = "Home group",
            Members = new List<User>
            {
                MockedUsers.Piotrek,
                MockedUsers.Bartek,
                MockedUsers.Mateusz,
                MockedUsers.Patryk
            }
        };
    }
}