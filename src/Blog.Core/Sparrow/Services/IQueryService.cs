using System;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public interface IQueryService<TEntity, TKey, TReqDto, TRespDto>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 根据唯一标识获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TRespDto Find(TKey id);

        /// <summary>
        /// 异步根据唯一标识获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TRespDto> FindAsync(TKey id);

        /// <summary>
        /// 获得实体总数
        /// </summary>
        /// <returns></returns>
        long Count();

        /// <summary>
        /// 异步获得实体总数
        /// </summary>
        /// <returns></returns>
        Task<long> CountAsync();
    }
}
