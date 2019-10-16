using Blog.Core.Sparrow;
using Blog.Core.Sparrow.Stores;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Stores.Mongo
{
    public class MongoStore<TEntity, TKey> : ICurlStore<TEntity, TKey>
        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        private readonly IMongoAccessor _mongoAccessor;
        private readonly string _collection = nameof(TEntity);

        IMongoCollection<TEntity> Collection => _mongoAccessor.GetCollection<TEntity>(_collection);

        public MongoStore(IMongoAccessor mongoAccessor)
        {
            _mongoAccessor = mongoAccessor;
        }

        public long Count()
        {
            return Collection.CountDocuments(FilterDefinition<TEntity>.Empty);
        }

        public long Count(Expression<Func<TEntity, bool>> predicate)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            return Collection.CountDocuments(builder.Where(predicate));
        }

        public async Task<long> CountAsync()
        {
            return await Collection.CountDocumentsAsync(FilterDefinition<TEntity>.Empty);
        }

        public async Task<long> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            return await Collection.CountDocumentsAsync(builder.Where(predicate));
        }

        public TEntity Create(TEntity entity)
        {
            Collection.InsertOne(entity);
            return entity;
        }

        public TKey CreateAndGetId(TEntity entity)
        {
            Collection.InsertOne(entity);
            return entity.Id;
        }

        public async Task<TKey> CreateAndGetIdAsync(TEntity entity)
        {
            await Collection.InsertOneAsync(entity);
            return entity.Id;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await Collection.InsertOneAsync(entity);
            return entity;
        }

        public TEntity Find(TKey id)
        {
            return Collection.Find(s => s.Id.Equals(id)).First();
        }

        public Task<TEntity> FindAsync(TKey id)
        {
            return Collection.Find(s => s.Equals(id)).FirstAsync();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Collection.Find(predicate).FirstOrDefault();
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Collection.Find(predicate).FirstOrDefaultAsync();
        }

        public IQueryable<TEntity> Query()
        {
            return Collection.AsQueryable();
        }

        public bool Remove(TEntity entity)
        {
            return Remove(entity.Id);
        }

        public bool Remove(TKey id)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            return Collection.DeleteOne(builder.Eq("Id", id)).DeletedCount > 0;
        }

        public bool Remove(Expression<Func<TEntity, bool>> predicate)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            return Collection.DeleteOne(builder.Where(predicate)).DeletedCount > 0;
        }

        public Task<bool> RemoveAsync(TEntity entity)
        {
            return RemoveAsync(entity.Id);
        }

        public async Task<bool> RemoveAsync(TKey id)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            var deleteRes = await Collection.DeleteOneAsync(builder.Eq("Id", id));
            return deleteRes.DeletedCount > 0;
        }

        public async Task<bool> RemoveAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            var deleteRes = await Collection.DeleteOneAsync(builder.Where(predicate));
            return deleteRes.DeletedCount > 0;
        }

        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            return Collection.Find(builder.Where(predicate)).Single();
        }

        public Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            return Collection.Find(builder.Where(predicate)).SingleAsync();
        }

        public TEntity Update(TEntity entity)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            Collection.ReplaceOne(builder.Eq("Id", entity.Id), entity);
            return entity;
        }

        public TEntity Update(TKey id, Action<TEntity> updateAction)
        {
            var entity = Find(id);
            updateAction(entity);

            var builder = new FilterDefinitionBuilder<TEntity>();
            Collection.ReplaceOne(builder.Eq("Id", id), entity);
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var builder = new FilterDefinitionBuilder<TEntity>();
            await Collection.ReplaceOneAsync(builder.Eq("Id", entity.Id), entity);
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TKey id, Func<TEntity, Task> updateAction)
        {
            var entity = Find(id);
            await updateAction(entity);

            var builder = new FilterDefinitionBuilder<TEntity>();
            Collection.ReplaceOne(builder.Eq("Id", id), entity);
            return entity;
        }

        public void CreateMany(IEnumerable<TEntity> entities)
        {
            Collection.InsertMany(entities);
        }

        public Task CreateManyAsync(IEnumerable<TEntity> entities)
        {
            return Collection.InsertManyAsync(entities);
        }

        public async Task<(IEnumerable<TEntity> Entities, long Total)> PageQuery(Expression<Func<TEntity, bool>> predicate, (string field, bool asc)[] sorters, int index, int size)
        {
            var filter = new FilterDefinitionBuilder<TEntity>();
            var sorter = new SortDefinitionBuilder<TEntity>();

            var sortDef = sorter.Combine(
                sorters.Select(s => s.asc ?
                    sorter.Ascending(s.field) :
                    sorter.Descending(s.field))
                );

            var finder = Collection.Find(filter.Where(predicate));

            return (
                await finder.Sort(sortDef).Skip(size * (index - 1)).Limit(size).ToListAsync(),
                await finder.CountDocumentsAsync()
                );
        }

        public async Task<(IEnumerable<TEntity> Entities, long Total)> PageQuery(Expression<Func<TEntity, bool>> predicate, (Expression<Func<TEntity, object>> selector, bool asc)[] sorters, int index, int size)
        {
            var filter = new FilterDefinitionBuilder<TEntity>();
            var sorter = new SortDefinitionBuilder<TEntity>();

            var sortDef = sorter.Combine(
                sorters.Select(s => s.asc ?
                    sorter.Ascending(s.selector) :
                    sorter.Descending(s.selector))
                );

            var finder = Collection.Find(filter.Where(predicate));

            return (
                await finder.Sort(sortDef).Skip(size * (index - 1)).Limit(size).ToListAsync(),
                await finder.CountDocumentsAsync()
                );
        }

        public TEntity Update(TKey id, params (string Field, object Value)[] selectors)
        {
            var filter = new FilterDefinitionBuilder<TEntity>();
            var updator = new UpdateDefinitionBuilder<TEntity>();
            var updateDef = updator.Combine(selectors.Select(s => updator.AddToSet(s.Field, s.Value)));
            Collection.UpdateOne(filter.Eq("Id", id), updateDef);
            return Find(id);
        }

        public Task<TEntity> UpdateAsync(TKey id, params (string Field, object Value)[] selectors)
        {
            throw new NotImplementedException();
        }
    }
}
