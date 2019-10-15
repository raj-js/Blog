using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Stores
{
    public interface IQueryStore<TEntity> : IQueryStore<TEntity, int> where TEntity : IEntity
    { 
    
    }

    public interface IQueryStore<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        /// <summary>
        /// 获取所有实体作为 IQueryable<>
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> Query();

        /// <summary>
        /// 根据唯一标识获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Find(TKey id);

        /// <summary>
        /// 异步根据唯一标识获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> FindAsync(TKey id);

        /// <summary>
        /// 根据 prediacate 查询唯一实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TEntity Single(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 异步根据 predicate 查询唯一实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 根据 predicate 查询第一个满足条件的实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 异步根据 predicate 查询第一个满足条件的实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
