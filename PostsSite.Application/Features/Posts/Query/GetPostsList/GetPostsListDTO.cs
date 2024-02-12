using System;

namespace PostsSite.Application.Features.Posts.Query.GetPostsList
{
    public class GetPostsListDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
