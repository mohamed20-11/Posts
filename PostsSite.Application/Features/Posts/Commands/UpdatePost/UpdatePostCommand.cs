using MediatR;
using System;

namespace PostsSite.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommand :  IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public Guid CategoryId { get; set; }
    }
}
