using System;

namespace BlingBackend.Model.Mocked
{
    public static class MockedTasks
    {
        public static Task BuyBeer = new Task
        {
            Id = 1,
            Description = "Buy fav beer",
            Category = MockedCategories.ShoppingCategory,
            Owner = MockedUsers.Mateusz,
            Title = "Buy beer",
            CompletitionDate = null,
            Creator = MockedUsers.Patryk,
            DueDate = DateTime.Now.AddDays(20),
            Status = TaskStatus.New
        };

        public static Task WashDishes = new Task
        {
            Id = 2,
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
            Id = 3,
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