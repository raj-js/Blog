using System;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public interface IUpdateService<TEntity, TKey, TReq, TResp>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TResp Update(TReq entity);

        /// <summary>
        /// 异步更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TResp> UpdateAsync(TReq entity);

        /// <summary>
        /// 根据唯一标识更新实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateAction"></param>
        /// <returns></returns>
        TResp Update(TKey id, Action<TReq> updateAction);

        /// <summary>
        /// 异步根据唯一标识更新实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateAction"></param>
        /// <returns></returns>
        Task<TResp> UpdateAsync(TKey id, Func<TReq, Task> updateAction);
    }
}
