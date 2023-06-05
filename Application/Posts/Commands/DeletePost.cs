using MediatR;


namespace Application.Posts.Commands
{
    public class DeletePost : IRequest //make public
    {
        public int PostId { get; set; }
    }
}
