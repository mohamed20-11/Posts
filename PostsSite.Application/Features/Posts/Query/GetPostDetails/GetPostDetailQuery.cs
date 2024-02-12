using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsSite.Application.Features.Posts.Query.GetPostDetails
{
    public class GetPostDetailQuery : IRequest<GetPostDeatailDTO>
    {
        public Guid PostId { get; set; }
    }
}
