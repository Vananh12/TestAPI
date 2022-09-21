namespace MXHAPI.Models
{
    public class Comment : Post
    {
        public string Content { get; set; }
        public Guid AuthorId { get; set; }
        public User Author { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }

    }
}
