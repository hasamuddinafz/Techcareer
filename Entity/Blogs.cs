using System.ComponentModel.DataAnnotations;

namespace Blog.Entity{
    public class Blogs{
        [Key]
        public int BlogId {get; set;}
        public string? Title {get; set;}
        public string? Description {get; set;}
        public string? Category {get; set;}         
        public string? PostImage{get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
        public bool isActive {get; set;}
        public int UserId {get; set;}
        public Users User {get; set;} = null!;
        public List<Tags> Tags {get; set;} = new List<Tags>();
        public List<Comments> Comments {get; set;} = new List<Comments>();
    }
}