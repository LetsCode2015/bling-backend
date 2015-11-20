using System;

namespace BlingBackend.Model
{
    public class Reminder
    {
        public int Id { get; set; }
        public virtual Task Task { get; set; }
        public TimeSpan Time { get; set; }
    }
}