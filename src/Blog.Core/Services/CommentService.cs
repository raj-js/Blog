using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.Services;
using Blog.Core.Sparrow.Stores;

namespace Blog.Core.Services
{
    public class CommentService : CURLService<Comment, string, CommentCreateDTO, CommentUpdateDTO, CommentDTO>, ICommentService
    {
        public CommentService(IMapper mapper, ICURLStore<Comment, string> store) : base(mapper, store)
        {
        }
    }
}
