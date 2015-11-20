using System;

namespace BlingBackend.Model.Mocked
{
    public static class MockedUsers
    {
        public static User Mateusz = new User
        {
            Name = "Mateusz",
            Facebook = string.Empty,
            Login = "Mateusz",
            Password = "Test123",
            Twitter = string.Empty
        };

        public static User Bartek = new User
        {
            Name = "Bartek",
            Facebook = string.Empty,
            Login = "Bartek",
            Password = "Test123",
            Twitter = string.Empty
        };

        public static User Patryk = new User
        {
            Id = 5,
            Name = "Patryk1",
            Facebook = string.Empty,
            Login = "Patryk",
            Password = "Test123",
            Twitter = string.Empty
        };

        public static User Piotrek = new User
        {
            Name = "Piotrek",
            Facebook = string.Empty,
            Login = "Piotrek",
            Password = "Test123",
            Twitter = string.Empty
        };
    }
}