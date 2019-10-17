using Blog.Core.Sparrow.DTOs.Paging;
using Blog.Core.Sparrow.DTOs.Response;
using Blog.Core.Sparrow.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.ApiControllers
{
    [ApiController]
    public abstract class CURLApiControllerBase<TEntity, TKey, TCreateDTO, TUpdateDTO, TDTO> : ControllerBase
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        protected readonly ICURLService<TEntity, TKey, TCreateDTO, TUpdateDTO, TDTO> CURLService;

        public CURLApiControllerBase(ICURLService<TEntity, TKey, TCreateDTO, TUpdateDTO, TDTO> curlService)
        {
            CURLService = curlService;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="query">查询条件</param>
        /// <returns></returns>
        [HttpGet("paging")]
        public virtual async Task<ApiResponse<Paged<TDTO>>> Paging([FromQuery]PageQuery query)
        {
            var result = await CURLService.PageQuery(query.PageIndex, query.PageSize, (query.Order, query.IsAsc));
            return ApiResponse.Success(PagingHelper.From(result.List, result.Total));
        }

        /// <summary>
        /// 根据唯一标识获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public virtual async Task<ApiResponse<TDTO>> Get(TKey id)
        {
            return ApiResponse.Success(await CURLService.FindAsync(id));
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public virtual async Task<ApiResponse<TDTO>> Post([FromBody]TCreateDTO dto)
        {
            return ApiResponse.Success(await CURLService.CreateAsync(dto));
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut]
        public virtual async Task<ApiResponse<TDTO>> Put([FromBody]TUpdateDTO dto)
        {
            return ApiResponse.Success(await CURLService.UpdateAsync(dto));
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public virtual async Task<ApiResponse> Delete(TKey id)
        {
            return ApiResponse.Assert(await CURLService.RemoveAsync(id));
        }
    }
}
