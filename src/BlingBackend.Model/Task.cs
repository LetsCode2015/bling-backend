using System;

namespace BlingBackend.Model
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime CompletitionDate { get; set; }

        public TaskCategory Category { get; set; }
    }
}