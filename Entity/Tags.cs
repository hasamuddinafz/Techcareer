using System.ComponentModel.DataAnnotations;

namespace Blog.Entity{
    public class Tags{
        [Key]
        public int TagId {get; set;}
        public string? tags {get; set;}
        public int BlogId {get; set;}
        public Blogs Blog {get; set;} =  null!;
    }
}