using AutoMapper;
using Posts.Domain;
using PostsSite.Application.Features.Posts.Commands.CreatePost;
using PostsSite.Application.Features.Posts.Commands.DeletePost;
using PostsSite.Application.Features.Posts.Commands.UpdatePost;
using PostsSite.Application.Features.Posts.Query.GetPostDetails;
using PostsSite.Application.Features.Posts.Query.GetPostsList;

namespace PostsSite.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Post, GetPostsListDTO>().ReverseMap();
            CreateMap<Post, GetPostDeatailDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, DeletePostCommand>().ReverseMap();

        }
    }
}
