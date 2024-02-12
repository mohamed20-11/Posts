using PostsSite.Application.Features.Posts.Query.GetPostsList;
using System;

namespace PostsSite.Application.Features.Posts.Query.GetPostDetails
{
    public class GetPostDeatailDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }
        public CategoryDTO Category { get; set; }
    }
}