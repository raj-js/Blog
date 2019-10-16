using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public interface ICreateService<TEntity, TKey, TReqDto, TRespDto>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="reqDto"></param>
        /// <returns></returns>
        TRespDto Create(TReqDto reqDto);

        /// <summary>
        /// 异步新增实体
        /// </summary>
        /// <param name="reqDto"></param>
        /// <returns></returns>
        Task<TRespDto> CreateAsync(TReqDto reqDto);

        /// <summary>
        /// 新增实体并返回唯一标识
        /// </summary>
        /// <param name="reqDto"></param>
        /// <returns></returns>
        TKey CreateAndGetId(TReqDto reqDto);

        /// <summary>
        /// 异步新增实体并返回唯一标识
        /// </summary>
        /// <param name="reqDto"></param>
        /// <returns></returns>
        Task<TKey> CreateAndGetIdAsync(TReqDto reqDto);

        /// <summary>
        /// 新增多个实体
        /// </summary>
        /// <param name="reqDtos"></param>
        /// <returns></returns>
        void CreateMany(IEnumerable<TReqDto> reqDtos);

        /// <summary>
        /// 新增多个实体
        /// </summary>
        /// <param name="reqDtos"></param>
        /// <returns></returns>
        Task CreateManyAsync(IEnumerable<TReqDto> reqDtos);
    }
}
