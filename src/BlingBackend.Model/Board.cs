﻿using System.Collections.Generic;

namespace BlingBackend.Model
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}