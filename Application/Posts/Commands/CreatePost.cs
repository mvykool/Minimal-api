﻿using Domain.Models;
using MediatR;

namespace Application.Posts.Commands
{
    public class CreatePost  : IRequest<Post>       //make public
    {
        public string? PostContent { get; set; }
    }
}
