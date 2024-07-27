using Blog.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data{
    public class BlogContext:DbContext{
        
        public BlogContext(DbContextOptions<BlogContext> options): base(options){}
        public DbSet<Blogs> Blogs => Set<Blogs>();
        public DbSet<Comments> Comments => Set<Comments>();
        public DbSet<Tags> Tags => Set<Tags>();
        public DbSet<Users> Users => Set<Users>();
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comments>()
                .HasOne(c => c.Blogs)
                .WithMany(b => b.Comments)
                .HasForeignKey(c => c.BlogId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comments>()
                .HasOne(c => c.Users)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
    }
}