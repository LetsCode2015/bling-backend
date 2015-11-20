using System.Collections.Generic;

namespace BlingBackend.Model
{
    public class Group : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Members { get; set; }
    }
}