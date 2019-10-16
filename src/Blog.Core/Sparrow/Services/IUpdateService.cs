using System;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public interface IUpdateService<TEntity, TKey, TReqDto, TRespDto>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="reqDto"></param>
        /// <returns></returns>
        TRespDto Update(TReqDto reqDto);

        /// <summary>
        /// 异步更新实体
        /// </summary>
        /// <param name="reqDto"></param>
        /// <returns></returns>
        Task<TRespDto> UpdateAsync(TReqDto reqDto);

        /// <summary>
        /// 部分更新
        /// </summary>
        /// <param name="id"></param>
        /// <param name="selectors"></param>
        /// <returns></returns>
        TRespDto Update(TKey id, params (string Field, object Value)[] selectors);

        /// <summary>
        /// 异步部分更新
        /// </summary>
        /// <param name="id"></param>
        /// <param name="selectors"></param>
        /// <returns></returns>
        Task<TRespDto> UpdateAsync(TKey id, params (string Field, object Value)[] selectors);
    }
}
