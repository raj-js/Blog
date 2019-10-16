using System;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Stores
{
    public interface IUpdateStore<TEntity> : IUpdateStore<TEntity, int> where TEntity : IEntity
    { 
    
    }

    public interface IUpdateStore<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// 异步更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity);

        /// <summary>
        /// 根据唯一标识更新实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateAction"></param>
        /// <returns></returns>
        TEntity Update(TKey id, Action<TEntity> updateAction);

        /// <summary>
        /// 异步根据唯一标识更新实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateAction"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TKey id, Func<TEntity, Task> updateAction);

    }
}
