namespace KanbanApi.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Column> Columns { get; set; } 
        public List<BoardMember> BMamberId { get; set; }
    }
}
