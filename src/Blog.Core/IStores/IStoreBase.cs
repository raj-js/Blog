using MongoDB.Bson;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.IStores
{
    public interface IStoreBase<TEntity>
    {
        Task<IQueryable<TEntity>> Query();

        Task<TEntity> Create(TEntity entity);

        Task<int> Delete(TEntity entity);

        Task<int> Modify(TEntity entity);

        Task<TEntity> Single(ObjectId id);
    }
}
