using System.Collections.Generic;

namespace BlingBackend.Model
{
    public class Group
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public List<User> Members { get; set; } 
    }
}