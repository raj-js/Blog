using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.Mapping;

namespace Blog.Core.Mapping
{
    public class CommentMapperConfiguration : MapperConfigurationBase<Comment, CommentCreateDTO, CommentUpdateDTO, CommentDTO>
    {
    }
}
