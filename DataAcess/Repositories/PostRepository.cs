using Application.Abstractions;             //add reference
using Domain.Models;
using Microsoft.EntityFrameworkCore;


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

        //GET ALL
        public async Task<ICollection<Post>> GetAllPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        //GET SINGLE
        public async Task<Post> GetPostById(int postId)
        {
            return await _context.Posts.FirstOrDefaultAsync(p => p.Id == postId);
        }


        //CREATE // POST  
        public async Task<Post> CreatePost(Post toCreate)
        {
            toCreate.DateCreated = DateTime.Now;
            toCreate.LastModified = DateTime.Now;
            _context.Posts.Add(toCreate);
            await _context.SaveChangesAsync();

            return toCreate;
        }

        //UPDATE
        public async Task<Post> UpdatePost(string updateContent, int postId)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(p => p.Id == postId);
            post.LastModified = DateTime.Now;
            post.Content = updateContent;
            await _context.SaveChangesAsync();
            return post;
        }

        //DELETE

        public async Task DeletePost(int postId)
        {
            var post = await _context.Posts
                .FirstOrDefaultAsync(p => p.Id == postId);

            if (post == null) return;

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }
    }
}
