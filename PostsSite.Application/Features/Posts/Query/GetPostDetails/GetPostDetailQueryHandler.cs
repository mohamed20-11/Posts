using AutoMapper;
using MediatR;
using PostsSite.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace PostsSite.Application.Features.Posts.Query.GetPostDetails
{
    public class GetPostDetailQueryHandler : IRequestHandler<GetPostDetailQuery,GetPostDeatailDTO>
    {
        private readonly IPostRepository _repository;
        private readonly IMapper _mapper;

        public GetPostDetailQueryHandler(IPostRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetPostDeatailDTO> Handle(GetPostDetailQuery query, CancellationToken cancellationToken)
        {
            var post = await _repository.GetPostByIdAsync(query.PostId,true);
            return _mapper.Map<GetPostDeatailDTO>(post);
        }
    }
}
