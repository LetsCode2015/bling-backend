using System;

namespace BlingBackend.Model.Mocked
{
    public static class MockedReminders
    {
        public static Reminder BuyBeerReminder = new Reminder
        {
            Id = 1,
            Task = MockedTasks.BuyBeer,
            Time = new TimeSpan(3, 0, 0, 0)
        };

        public static Reminder WashDishesReminder = new Reminder
        {
            Id = 2,
            Task = MockedTasks.WashDishes,
            Time = new TimeSpan(3, 0, 0, 0)
        };

        public static Reminder InviteFriendsReminder = new Reminder
        {
            Id = 3,
            Task = MockedTasks.WashDishes,
            Time = new TimeSpan(3, 0, 0, 0)
        };
    }
}