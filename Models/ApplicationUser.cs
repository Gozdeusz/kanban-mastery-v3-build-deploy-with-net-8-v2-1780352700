using Microsoft.AspNetCore.Identity;

namespace KanbanApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<BoardMember> BMemberId { get; set; }
    }
}
