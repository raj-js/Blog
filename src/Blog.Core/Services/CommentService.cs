using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.Services;
using Sparrow.Core.Stores;

namespace Blog.Core.Services
{
    public class CommentService : AppServiceBase<Comment, string, CommentCreateDTO, CommentUpdateDTO, CommentDTO>, ICommentService
    {
        public CommentService(IMapper mapper, ICURLStore<Comment, string> store) : base(mapper, store)
        {
        }
    }
}
