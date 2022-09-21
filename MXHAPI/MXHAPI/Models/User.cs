namespace MXHAPI.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string? DisplayName { get; set; }
        public DateTime DateofBirth { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<UserGroup> GroupsOfUser { get; set; }

    }
}
