using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Stores
{
    public interface IAggregateStore<TEntity> : IAggregateStore<TEntity, int> where TEntity : IEntity
    { 
    
    }

    public interface IAggregateStore<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        /// <summary>
        /// 获得实体总数
        /// </summary>
        /// <returns></returns>
        int Count();

        /// <summary>
        /// 异步获得实体总数
        /// </summary>
        /// <returns></returns>
        Task<int> CountAsync();

        /// <summary>
        /// 获取满足 predicate 的实体总数
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        int Count(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 异步获取满足 predicate 的实体总数
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 获取实体总数
        /// </summary>
        /// <returns></returns>
        long LongCount();

        /// <summary>
        /// 异步获取实体总数
        /// </summary>
        /// <returns></returns>
        Task<long> LongCountAsync();

        /// <summary>
        /// 获取满足 predicate 的实体总数
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        long LongCount(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 异步获取满足 predicate 的实体总数
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
