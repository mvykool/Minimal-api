using Application.Abstractions;
using Application.Posts.Commands;
using Domain.Models;
using MediatR;

namespace Application.Posts.CommandHandlers
{
    public class CreatePostHandler : IRequestHandler<CreatePost, Post>
    {
        private readonly IPostRepository _postRepo;

        public CreatePostHandler(IPostRepository postRepo)
        {
            _postRepo = _postRepo;
        }

        //make this async
        public async Task<Post> Handle(CreatePost request, CancellationToken cancellationToken) 
        {
            var newPost = new Post
            {
                Content = request.PostContent,
    
            };

            return await _postRepo.CreatePost(newPost);
        }
    }
}
