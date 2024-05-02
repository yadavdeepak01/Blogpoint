using Blogpoint.Web.Data;
using Blogpoint.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blogpoint.Web.Repositories
{
    public class BlogPostCommentRepository : IBlogPostCommentRepository
    {
        private readonly BlogpointDbContext BlogpointDbContext;

        public BlogPostCommentRepository(BlogpointDbContext BlogpointDbContext)
        {
            this.BlogpointDbContext = BlogpointDbContext;
        }

        public async Task<BlogPostComment> AddAsync(BlogPostComment blogPostComment)
        {
            await BlogpointDbContext.BlogPostComment.AddAsync(blogPostComment);
            await BlogpointDbContext.SaveChangesAsync();
            return blogPostComment;
        }

        public async Task<IEnumerable<BlogPostComment>> GetCommentsByBlogIdAsync(Guid blogPostId)
        {
            return await BlogpointDbContext.BlogPostComment.Where(x => x.BlogPostId == blogPostId)
                .ToListAsync();
        }
    }
}
