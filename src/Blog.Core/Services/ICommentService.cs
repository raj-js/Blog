using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.Services;

namespace Blog.Core.Services
{
    public interface ICommentService : ICURLService<Comment, string, CommentCreateDTO, CommentUpdateDTO, CommentDTO>
    {
    }
}
