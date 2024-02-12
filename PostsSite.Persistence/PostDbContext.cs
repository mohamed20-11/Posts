using Microsoft.EntityFrameworkCore;
using Posts.Domain;

namespace PostsSite.Persistence
{
    public class PostDbContext : DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<Post> Posts { get; set; } 
    }
}
