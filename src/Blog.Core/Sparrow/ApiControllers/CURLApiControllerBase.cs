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
        private readonly ICURLService<TEntity, TKey, TCreateDTO, TUpdateDTO, TDTO> _curlService;

        public CURLApiControllerBase(ICURLService<TEntity, TKey, TCreateDTO, TUpdateDTO, TDTO> curlService)
        {
            _curlService = curlService;
        }

        [HttpGet("paging")]
        public virtual async Task<ApiResponse<Paged<TDTO>>> Paging(PageQuery query)
        {
            var result = await _curlService.PageQuery(query.PageIndex, query.PageSize, (query.Order, query.IsAsc));
            return ApiResponse.Success(PagingHelper.From(result.List, result.Total));
        }

        [HttpGet("{id}")]
        public virtual async Task<ApiResponse<TDTO>> Get(TKey id)
        {
            return ApiResponse.Success(await _curlService.FindAsync(id));
        }

        [HttpPost]
        public virtual async Task<ApiResponse<TDTO>> Post([FromBody]TCreateDTO dto)
        {
            return ApiResponse.Success(await _curlService.CreateAsync(dto));
        }

        [HttpPut]
        public virtual async Task<ApiResponse<TDTO>> Put([FromBody]TUpdateDTO dto)
        {
            return ApiResponse.Success(await _curlService.UpdateAsync(dto));
        }

        [HttpDelete("{id}")]
        public virtual async Task<ApiResponse> Delete(TKey id)
        {
            return ApiResponse.Assert(await _curlService.RemoveAsync(id));
        }
    }
}
