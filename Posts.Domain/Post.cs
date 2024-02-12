using System;

namespace Posts.Domain
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
