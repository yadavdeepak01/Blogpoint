using Blogpoint.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blogpoint.Web.Data
{
    public class BlogpointDbContext : DbContext
    {
        public BlogpointDbContext(DbContextOptions<BlogpointDbContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogPostLike> BlogPostLike { get; set; }
        public DbSet<BlogPostComment> BlogPostComment { get; set; }
    }
}
