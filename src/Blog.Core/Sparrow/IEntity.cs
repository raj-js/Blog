using System;

namespace Blog.Core.Sparrow
{
    public interface IEntity<TKey> where TKey : IEquatable<TKey>
    {
        TKey Id { get; }
    }

    public interface IEntity : IEntity<int>
    {

    }
}
