using System;

namespace BlingBackend.Model
{
    public class Reminder
    {
        public int Id { get; set; }
        public Task Task { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime SpecificDate { get; set; }
    }
}