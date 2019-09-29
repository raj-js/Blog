using MongoDB.Driver;
using System.Collections.Concurrent;

namespace Blog.Core.Data
{
    public class MongoAccessor : IMongoAccessor
    {
        private IMongoOptions _options;
        private IMongoClient _client;
        private ConcurrentDictionary<string, IMongoDatabase> _mongoDatabases;

        public IMongoClient Client => _client ?? (_client = new MongoClient(_options.ClientSettings));

        public MongoAccessor(IMongoOptions options)
        {
            _options = options;
            _mongoDatabases = new ConcurrentDictionary<string, IMongoDatabase>();
        }

        public IMongoDatabase Database(string name)
            => _mongoDatabases.GetOrAdd(name, k => _client.GetDatabase(k, _options.DatabaseSettings));
    }
}
