using AutoMapper;
using MediatR;
using PostsSite.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostsSite.Application.Features.Posts.Query.GetPostsList
{
    public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, List<GetPostsListDTO>>
    {
        private readonly IPostRepository _repository;
        private readonly IMapper _mapper;

        public GetPostsListQueryHandler(IPostRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetPostsListDTO>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _repository.GetAllPostsAsync();
            return _mapper.Map<List<GetPostsListDTO>>(allPosts);

        }
    }
}
