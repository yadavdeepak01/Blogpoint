using Blogpoint.Web.Data;
using Blogpoint.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blogpoint.Web.Repositories
{
    public class BlogPostLikeRepository : IBlogPostLikeRepository
    {
        private readonly BlogpointDbContext BlogpointDbContext;

        public BlogPostLikeRepository(BlogpointDbContext BlogpointDbContext)
        {
            this.BlogpointDbContext = BlogpointDbContext;
        }

        public async Task<BlogPostLike> AddLikeForBlog(BlogPostLike blogPostLike)
        {
            await BlogpointDbContext.BlogPostLike.AddAsync(blogPostLike);
            await BlogpointDbContext.SaveChangesAsync();
            return blogPostLike;
        }

        public async Task<IEnumerable<BlogPostLike>> GetLikesForBlog(Guid blogPostId)
        {
            return await BlogpointDbContext.BlogPostLike.Where(x => x.BlogPostId == blogPostId)
                .ToListAsync();
        }

        public async Task<int> GetTotalLikes(Guid blogPostId)
        {
            return await BlogpointDbContext.BlogPostLike
                .CountAsync(x => x.BlogPostId == blogPostId);
        }
    }
}
