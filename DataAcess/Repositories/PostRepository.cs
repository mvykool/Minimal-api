using Application.Abstractions;             //add reference
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repositories
{
    public class PostRepository : IPostRepository  //it needs to be public
    {
        private readonly SocialDbContext _context;

        public PostRepository(SocialDbContext context)
        {
            _context = context;
        }

        //interfaces

        //CREATE    
        public async Task<Post> CreatePost(Post toCreate)
        {
            toCreate.DateCreated = DateTime.Now; 
            toCreate.LastModified = DateTime.Now;
            _context.Posts.Add(toCreate);
            await _context.SaveChangesAsync();

            return toCreate;
        }

        public Task DeletePost(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Post>> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostById(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePost(string updateContent, int postId)
        {
            throw new NotImplementedException();
        }
    }
}
