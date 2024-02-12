using Posts.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsSite.Application.Interfaces
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAllPostsAsync();
        Task<Post> GetPostByIdAsync(Guid id, bool includeCategory);
    }
}
