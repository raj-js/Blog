using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Sparrow.Services;
using Blog.Core.Sparrow.Stores;

namespace Blog.Core.Services
{
    public class TagService : ServiceBase<Tag, int, TagCreateDTO, TagDTO, TagDTO>, ITagService
    {
        public TagService(IMapper mapper, ICURLStore<Tag, int> store) : base(mapper, store)
        {
        }
    }
}
