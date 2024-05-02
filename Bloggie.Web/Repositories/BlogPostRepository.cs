using Blogpoint.Web.Data;
using Blogpoint.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blogpoint.Web.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly BlogpointDbContext BlogpointDbContext;

        public BlogPostRepository(BlogpointDbContext BlogpointDbContext)
        {
            this.BlogpointDbContext = BlogpointDbContext;
        }

        public async Task<BlogPost> AddAsync(BlogPost blogPost)
        {
            await BlogpointDbContext.AddAsync(blogPost);
            await BlogpointDbContext.SaveChangesAsync();
            return blogPost;
        }

        public async Task<BlogPost?> DeleteAsync(Guid id)
        {
            var existingBlog = await BlogpointDbContext.BlogPosts.FindAsync(id);

            if (existingBlog != null)
            {
                BlogpointDbContext.BlogPosts.Remove(existingBlog);
                await BlogpointDbContext.SaveChangesAsync();
                return existingBlog;
            }

            return null;
        }

        public async Task<IEnumerable<BlogPost>> GetAllAsync()
        {
            return await BlogpointDbContext.BlogPosts.Include(x => x.Tags).ToListAsync();
        }

        public async Task<BlogPost?> GetAsync(Guid id)
        {
            return await BlogpointDbContext.BlogPosts.Include(x => x.Tags).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<BlogPost?> GetByUrlHandleAsync(string urlHandle)
        {
            return await BlogpointDbContext.BlogPosts.Include(x => x.Tags)
                .FirstOrDefaultAsync(x => x.UrlHandle == urlHandle);
        }

        public async Task<BlogPost?> UpdateAsync(BlogPost blogPost)
        {
            var existingBlog = await BlogpointDbContext.BlogPosts.Include(x => x.Tags)
                .FirstOrDefaultAsync(x => x.Id == blogPost.Id);

            if (existingBlog != null)
            {
                existingBlog.Id = blogPost.Id;
                existingBlog.Heading = blogPost.Heading;
                existingBlog.PageTitle = blogPost.PageTitle;
                existingBlog.Content = blogPost.Content;
                existingBlog.ShortDescription = blogPost.ShortDescription;
                existingBlog.Author = blogPost.Author;
                existingBlog.FeaturedImageUrl = blogPost.FeaturedImageUrl;
                existingBlog.UrlHandle = blogPost.UrlHandle;
                existingBlog.Visible = blogPost.Visible;
                existingBlog.PublishedDate = blogPost.PublishedDate;
                existingBlog.Tags = blogPost.Tags;

                await BlogpointDbContext.SaveChangesAsync();
                return existingBlog;
            }

            return null;
        }
    }
}
