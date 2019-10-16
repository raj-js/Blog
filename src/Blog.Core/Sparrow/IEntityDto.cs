using System;

namespace Blog.Core.Sparrow
{
    public interface IEntityDto<TEntity, TKey> : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        TEntity ToEntity();
    }
}
