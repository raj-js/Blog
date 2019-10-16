using System;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public interface ICreateService<TEntity, TKey, TReq, TResp>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TResp Create(TReq entity);

        /// <summary>
        /// 异步新增实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TResp> CreateAsync(TReq entity);

        /// <summary>
        /// 新增实体并返回唯一标识
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TKey CreateAndGetId(TReq entity);

        /// <summary>
        /// 异步新增实体并返回唯一标识
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TKey> CreateAndGetIdAsync(TReq entity);
    }
}
