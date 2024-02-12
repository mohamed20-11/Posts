using Microsoft.EntityFrameworkCore;
using Posts.Domain;
using PostsSite.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostsSite.Persistence.Repositories
{
    public class PostRepository : BaseRepositories<Post>, IPostRepository
    {
        public PostRepository(PostDbContext postDb): base(postDb)
        {
            
        }

        public async Task<IReadOnlyList<Post>> GetAllPostsAsync(bool includeCategory)
        {
            List<Post> posts = new List<Post>();
            posts=includeCategory ? await _dbContext.Posts.Include(x=>x.Category).ToListAsync() : await _dbContext.Posts.ToListAsync();
            return posts;
        }

        public Task<IReadOnlyList<Post>> GetAllPostsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetPostByIdAsync(Guid id, bool includeCategory)
        {
            Post post = new Post();
            post = includeCategory ? await _dbContext.Posts.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id) : await GetByIdAsync(id);
            return post;
        }
    }
}
