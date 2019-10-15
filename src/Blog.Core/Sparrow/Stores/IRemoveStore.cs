using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Stores
{
    public interface IRemoveStore<TEntity> : IRemoveStore<TEntity, int> where TEntity : IEntity
    { 
    
    }

    public interface IRemoveStore<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);

        /// <summary>
        /// 异步删除实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task RemoveAsync(TEntity entity);

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
        void Remove(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 异步删除满足 predicate 的实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task RemoveAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
