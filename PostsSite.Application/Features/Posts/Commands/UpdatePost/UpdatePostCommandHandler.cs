using AutoMapper;
using MediatR;
using Posts.Domain;
using PostsSite.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostsSite.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand>
    {
        private readonly IPostRepository _repository;
        private readonly IMapper _mapper;

        public UpdatePostCommandHandler(IPostRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePostCommand updatePostCommand , CancellationToken cancellationToken)
        {
            Post post = _mapper.Map<Post>(updatePostCommand);
            await _repository.UpdateAync(post);
            return Unit.Value;
        }
    }
}
