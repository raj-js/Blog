using AutoMapper;
using Blog.Core.Sparrow.Stores;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public interface IQueryService<TEntity, TKey, TReq, TResp>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        IMapper Mapper { get; }

        IQueryStore<TEntity, TKey> QueryStore { get; }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <param name="orderby"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        Task<IEnumerable<TResp>> PageQuery(Expression<Func<TReq, bool>> predicate, int index, int size, string orderby, out int total);

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TResp>> GetAll();

        /// <summary>
        /// 根据唯一标识获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TResp Find(TKey id);

        /// <summary>
        /// 异步根据唯一标识获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TResp> FindAsync(TKey id);

        /// <summary>
        /// 根据 prediacate 查询唯一实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TResp Single(Expression<Func<TReq, bool>> predicate);

        /// <summary>
        /// 异步根据 predicate 查询唯一实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TResp> SingleAsync(Expression<Func<TReq, bool>> predicate);

        /// <summary>
        /// 根据 predicate 查询第一个满足条件的实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TResp FirstOrDefault(Expression<Func<TReq, bool>> predicate);

        /// <summary>
        /// 异步根据 predicate 查询第一个满足条件的实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TResp> FirstOrDefaultAsync(Expression<Func<TReq, bool>> predicate);

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
        int Count(Expression<Func<TReq, bool>> predicate);

        /// <summary>
        /// 异步获取满足 predicate 的实体总数
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<int> CountAsync(Expression<Func<TReq, bool>> predicate);

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
        long LongCount(Expression<Func<TReq, bool>> predicate);

        /// <summary>
        /// 异步获取满足 predicate 的实体总数
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<long> LongCountAsync(Expression<Func<TReq, bool>> predicate);
    }
}
