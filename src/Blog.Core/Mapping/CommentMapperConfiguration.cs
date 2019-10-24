using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.Mapping;

namespace Blog.Core.Mapping
{
    public class CommentMapperConfiguration : MapperConfigurationBase<Comment, CommentCreateDTO, CommentUpdateDTO, CommentDTO>
    {
    }
}
