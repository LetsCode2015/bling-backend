﻿using System;

namespace BlingBackend.Model
{
    public class Task : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public TaskStatus Status { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? CompletitionDate { get; set; }

        public int BoardId { get; set; }

        public virtual Category Category { get; set; }

        public virtual User Creator { get; set; }

        public virtual User Owner { get; set; }
    }
}