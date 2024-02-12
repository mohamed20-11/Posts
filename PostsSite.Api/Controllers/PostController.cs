using MediatR;
using Microsoft.AspNetCore.Mvc;
using Posts.Domain;
using PostsSite.Application.Features.Posts.Commands.CreatePost;
using PostsSite.Application.Features.Posts.Commands.DeletePost;
using PostsSite.Application.Features.Posts.Commands.UpdatePost;
using PostsSite.Application.Features.Posts.Query.GetPostDetails;
using PostsSite.Application.Features.Posts.Query.GetPostsList;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostsSite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet ("all", Name="GetAllPosts")]
        public async Task<ActionResult<List<GetPostsListDTO>>> GetAllPosts()
        {
            var dtos = await _mediator.Send(new GetPostsListQuery());
            return Ok(dtos);
        }
        [HttpGet ("{id}" , Name ="GetPostById")]
        public async Task<ActionResult<GetPostDeatailDTO>> GetPostById(Guid id)
        {
            var getPost = await _mediator.Send(new GetPostDetailQuery() { PostId = id });
            return Ok(await _mediator.Send(getPost));
        }

        [HttpPost(Name ="AddPost")]
        public async Task<ActionResult<Guid>> AddPost([FromBody] CreatePostCommand postCommand)
        {
            Guid id = await _mediator.Send(postCommand);
            return Ok(id);
        }
        [HttpPut(Name ="UpdatePost")]
        public async Task<ActionResult> Update([FromBody] UpdatePostCommand updatePostCommand)
        {
            await _mediator.Send(updatePostCommand);
            return NoContent();
        }

        [HttpDelete("{id}" , Name ="Delete")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deletedPost = new DeletePostCommand() { PostId = id };
            await _mediator.Send(deletedPost);
            return NoContent();
        }
    }
}
