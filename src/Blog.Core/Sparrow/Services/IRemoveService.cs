using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public interface IRemoveService<TEntity, TKey, TReq, TResp>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TReq entity);

        /// <summary>
        /// 异步删除实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task RemoveAsync(TReq entity);

        /// <summary>
        /// 删除指定唯一标识的实体
        /// </summary>
        /// <param name="id"></param>
        void Remove(TKey id);

        /// <summary>
        /// 异步删除指定唯一标识的实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveAsync(TKey id);

        /// <summary>
        /// 删除满足 predicate 的实体
        /// </summary>
        /// <param name="predicate"></param>
        void Remove(Expression<Func<TReq, bool>> predicate);

        /// <summary>
        /// 异步删除满足 predicate 的实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task RemoveAsync(Expression<Func<TReq, bool>> predicate);
    }
}
