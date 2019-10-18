using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.Services;

namespace Blog.Core.Services
{
    public interface ITagService : ICURLService<Tag, int, TagCreateDTO, TagDTO, TagDTO>
    {
    }
}
