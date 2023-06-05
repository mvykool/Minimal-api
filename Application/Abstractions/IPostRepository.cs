using Domain.Models;     //add domain reference
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IPostRepository  //make public
    {
        Task<ICollection<Post>> GetAllPosts();

        Task<Post> GetPostById(int postId);

        Task<Post> CreatePost(Post toCreate);

        Task<Post> UpdatePost(string updateContent, int postId);

        Task DeletePost(int postId);
    }
}