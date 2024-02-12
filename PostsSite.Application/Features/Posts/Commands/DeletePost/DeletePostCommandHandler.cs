using AutoMapper;
using MediatR;
using PostsSite.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace PostsSite.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand>
    {
        private readonly IPostRepository _repository;
        public DeletePostCommandHandler(IPostRepository repository, IMapper mapper)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _repository.GetByIdAsync(request.PostId);

            await _repository.DeleteAync(post);
            return Unit.Value;
        }
    }
}
