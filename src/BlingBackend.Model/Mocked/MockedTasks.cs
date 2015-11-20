using System;

namespace BlingBackend.Model.Mocked
{
    public static class MockedTasks
    {
        public static Task BuyBeer = new Task
        {
            Description = "Buy fav beer",
            Category = MockedCategories.HomeCategory,
            Owner = MockedUsers.Patryk,
            Title = "Buy beer",
            CompletitionDate = null,
            Creator = MockedUsers.Patryk,
            DueDate = DateTime.Now.AddDays(20),
            Status = TaskStatus.New,
            BoardId = 1
        };

        public static Task WashDishes = new Task
        {
            Description = "Wash all dishes",
            Category = MockedCategories.HomeCategory,
            Owner = MockedUsers.Piotrek,
            Title = "Wash dishes",
            CompletitionDate = null,
            Creator = MockedUsers.Piotrek,
            DueDate = DateTime.Now.AddDays(20),
            Status = TaskStatus.New
        };

        public static Task InviteFriends = new Task
        {
            Id = 0,
            Description = "Invite friends",
            Category = MockedCategories.HomeCategory,
            Owner = MockedUsers.Piotrek,
            Title = "Invite friends",
            CompletitionDate = null,
            Creator = MockedUsers.Piotrek,
            DueDate = DateTime.Now.AddDays(20),
            Status = TaskStatus.InProgress
        };
    }
}