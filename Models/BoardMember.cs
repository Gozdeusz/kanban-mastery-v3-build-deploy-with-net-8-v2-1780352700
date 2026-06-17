namespace KanbanApi.Models
{
    public class BoardMember
    {
        public ApplicationUser User { get; set; }
        public Board Board { get; set; }
        public Role Role { get; set; }

        public string UserId { get; set; }
        public int BoardId { get; set; }

    }

    public enum Role
    {
        Owner,
        Member
    }
}
