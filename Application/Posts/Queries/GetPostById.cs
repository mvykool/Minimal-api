using Domain.Models;
using MediatR;


namespace Application.Posts.Queries
{
    internal class GetPostById : IRequest<Post>
    {
        public int PostId { get; set; }
    }
}
