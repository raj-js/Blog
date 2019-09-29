using Blog.Core.IStores;
using MongoDB.Bson;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Stores
{
    public class StoreBase<TEntity> : IStoreBase<TEntity>
    {
        public Task<TEntity> Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Modify(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<TEntity>> Query()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Single(ObjectId id)
        {
            throw new NotImplementedException();
        }
    }
}
