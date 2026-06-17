namespace KanbanApi.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Column ColumnId { get; set; }
    }
}
