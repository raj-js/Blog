using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.Services;

namespace Blog.Core.Services
{
    public interface ICommentService : IAppService<Comment, string, CommentCreateDTO, CommentUpdateDTO, CommentDTO>
    {
    }
}
