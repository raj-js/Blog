using Blog.Core.DTOs;
using Blog.Core.Models;
using Sparrow.Core.DTOs.Responses;
using Sparrow.Core.Services;
using System.Collections.Generic;

namespace Blog.Core.Services
{
    public interface ITagService : IAppService<Tag, int, TagCreateDTO, TagDTO, TagDTO>
    {
        /// <summary>
        /// 获取启用的标签
        /// </summary>
        /// <returns></returns>
        OpResponse<List<TagDTO>> GetEnabledTags();
    }
}
