using System.ComponentModel.DataAnnotations;

namespace Blog.Entity{
    public class Comments{
        [Key]
        public int CommentID {get; set;}
        public string? Comment {get; set;}
        public DateTime PublishedOn {get; set;}
        public int BlogId {get; set;}

        public Blogs Blogs {get; set;} = null!;
        public int UserId {get; set;}
        public Users Users {get; set;} = null!;
    }
}