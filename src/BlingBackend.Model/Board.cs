namespace BlingBackend.Model
{
    public class Board
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public List<Task> Tasks { get; set; } 
    }
}