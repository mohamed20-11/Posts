using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsSite.Application.Features.Posts.Query.GetPostsList
{
    public class GetPostsListQuery : IRequest<List<GetPostsListDTO>>
    {

    }
}
