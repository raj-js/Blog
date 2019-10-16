using System;

namespace Blog.Core.Sparrow.Services
{
    public interface ICurlService<
        TEntity, TKey,
        TCreateReq, TUpdateReq, TReq,
        TCreateResp, TUpdateResp, TResp
        > :
        ICurlService<
            TEntity, TKey,
            TCreateReq, TReq, TUpdateReq, TReq,
            TCreateResp, TResp, TUpdateResp, TResp
            >
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {

    }

    public interface ICurlService<
        TEntity, TKey,
        TCreateReq, TRemoveReq, TUpdateReq, TQueryReq,
        TCreateResp, TRemoveResp, TUpdateResp, TQueryResp
        > :
        ICreateService<TEntity, TKey, TCreateReq, TCreateResp>,
        IRemoveService<TEntity, TKey, TRemoveReq, TRemoveResp>,
        IUpdateService<TEntity, TKey, TUpdateReq, TUpdateResp>,
        IQueryService<TEntity, TKey, TQueryReq, TQueryResp>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {

    }
}
