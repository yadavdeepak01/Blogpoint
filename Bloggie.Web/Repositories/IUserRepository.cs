using Microsoft.AspNetCore.Identity;

namespace Blogpoint.Web.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetAll();
    }
}
