using MediatR;
using PostsSite.Application.Features.Posts.Query.GetPostsList;
using System;

namespace PostsSite.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }
        public Guid CategoryId { get; set; }
    }
}
