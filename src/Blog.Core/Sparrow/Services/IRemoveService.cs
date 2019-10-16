using System;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public interface IRemoveService<TEntity, TKey, TReqDto>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="reqDto"></param>
        bool Remove(TReqDto reqDto);

        /// <summary>
        /// 异步删除实体
        /// </summary>
        /// <param name="reqDto"></param>
        /// <returns></returns>
        Task<bool> RemoveAsync(TReqDto reqDto);

        /// <summary>
        /// 删除指定唯一标识的实体
        /// </summary>
        /// <param name="id"></param>
        bool Remove(TKey id);

        /// <summary>
        /// 异步删除指定唯一标识的实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> RemoveAsync(TKey id);
    }
}
