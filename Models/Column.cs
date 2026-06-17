namespace KanbanApi.Models
{
    public class Column
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public Board BoardId { get; set; }
    }
}
