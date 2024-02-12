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

namespace PostsSite.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand,Guid>
    {
        private readonly IPostRepository _repository;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IPostRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreatePostCommand command , CancellationToken cancellationToken)
        {
            Post post = _mapper.Map<Post>(command);
            CreateCommandValidator validator = new CreateCommandValidator();
            var result = await validator.ValidateAsync(command);
            if(result.Errors.Any())
            {
                throw new Exception("Post isn't valid");
            }

            post = await _repository.AddAync(post);
            return post.Id;
        }
    }
}
