using AutoMapper;
using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.DTOs.Responses;
using Sparrow.Core.Services;
using Sparrow.Core.Stores;
using System.Collections.Generic;
using System.Linq;
using static Sparrow.Core.DTOs.Responses.OpResponse;

namespace Blog.Core.Services
{
    public class TagService : AppServiceBase<Tag, int, TagCreateDTO, TagDTO, TagDTO>, ITagService
    {
        public TagService(IMapper mapper, IStore<Tag, int> store) : base(mapper, store)
        {
        }

        public OpResponse<List<TagDTO>> GetEnabledTags()
        {
            var tags = Store
                .Query()
                .Where(s => s.Enable)
                .Select(ToListItemDTO)
                .ToList();

            return Success(tags);
        }
    }
}
