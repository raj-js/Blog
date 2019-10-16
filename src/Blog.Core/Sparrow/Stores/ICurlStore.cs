using System;

namespace Blog.Core.Sparrow.Stores
{
    public interface ICurlStore<TEntity> : ICurlStore<TEntity, int> where TEntity : IEntity
    {

    }

    public interface ICurlStore<TEntity, TKey> :
        ICreateStore<TEntity, TKey>,
        IRemoveStore<TEntity, TKey>,
        IUpdateStore<TEntity, TKey>,
        IQueryStore<TEntity, TKey>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {

    }
}
