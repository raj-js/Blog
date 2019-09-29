using MongoDB.Driver;

namespace Blog.Core.Data
{
    /// <summary>
    /// <ref>http://mongodb.github.io/mongo-csharp-driver/2.9/reference/driver/connecting/</ref>
    /// 
    /// It is recommended to store a MongoClient instance in a global place, 
    /// either as a static variable or in an IoC container with a singleton lifetime.
    /// </summary>
    public interface IMongoAccessor
    {
        IMongoClient Client { get; }

        IMongoDatabase Database(string name);
    }
}
