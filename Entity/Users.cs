using System.ComponentModel.DataAnnotations;

namespace Blog.Entity{
    public class Users{
        [Key]
        public int UserId {get; set;}
        public string? Username {get; set;}

        public List<Blogs> Blogs {get; set;} = new List<Blogs>();
        public List<Comments> Comments {get; set;} = new List<Comments>();
    }
}