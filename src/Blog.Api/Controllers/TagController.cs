using Blog.Core.DTOs;
using Blog.Core.Models;
using Blog.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Sparrow.Core.ApiControllers;
using Sparrow.Core.DTOs.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    /// <summary>
    /// 标签
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ApiControllerBase<Tag, int, TagCreateDTO, TagDTO, TagDTO>
    {
        private readonly ITagService _tagService;

        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="tagService"></param>
        public TagController(ITagService tagService) : base(tagService)
        {
            _tagService = tagService;
        }

        /// <summary>
        /// 获取所有启用的分类
        /// </summary>
        /// <returns></returns>
        [HttpGet("all/enabled")]
        public OpResponse<List<TagDTO>> GetEnabledCategories()
        {
            return _tagService.GetEnabledTags();
        }
    }
}