using AutoMapper;
using Blog.Core.Sparrow.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public class CURLService
        <
        TEntity, TKey,
        TCreateDTO, TUpdateDTO,
        TDTO
        > :

        ICreateService<TEntity, TKey, TCreateDTO, TDTO>,
        IRemoveService<TEntity, TKey>,
        IUpdateService<TEntity, TKey, TUpdateDTO, TDTO>,
        IQueryService<TEntity, TKey, TDTO>,
        ICURLService
        <
        TEntity, TKey,
        TCreateDTO, TUpdateDTO,
        TDTO
        >

        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        protected IMapper Mapper { get; private set; }
        protected ICURLStore<TEntity, TKey> Store { get; private set; }

        public CURLService(IMapper mapper, ICURLStore<TEntity, TKey> store)
        {
            Mapper = mapper;
            Store = store;
        }

        #region protected

        protected virtual TEntity ToEntity(object dto) => Mapper.Map<TEntity>(dto);
        protected virtual TDTO ToDTO(TEntity entity) => Mapper.Map<TDTO>(entity);

        #endregion

        public long Count()
        {
            return Store.Count();
        }

        public Task<long> CountAsync()
        {
            return Store.CountAsync();
        }

        public TDTO Create(TCreateDTO createDTO)
        {
            var entity = Store.Create(ToEntity(createDTO));
            return ToDTO(entity);
        }

        public TKey CreateAndGetId(TCreateDTO createDTO)
        {
            return Store.CreateAndGetId(ToEntity(createDTO));
        }

        public Task<TKey> CreateAndGetIdAsync(TCreateDTO createDTO)
        {
            return Store.CreateAndGetIdAsync(ToEntity(createDTO));
        }

        public async Task<TDTO> CreateAsync(TCreateDTO createDTO)
        {
            var entity = await Store.CreateAsync(ToEntity(createDTO));
            return ToDTO(entity);
        }

        public void CreateMany(IEnumerable<TCreateDTO> createDTOs)
        {
            var entities = createDTOs.Select(s => ToEntity(s));
            Store.CreateMany(entities);
        }

        public Task CreateManyAsync(IEnumerable<TCreateDTO> createDTOs)
        {
            var entities = createDTOs.Select(s => ToEntity(s));
            return Store.CreateManyAsync(entities);
        }

        public TDTO Find(TKey id)
        {
            var entity = Store.Find(id);
            return ToDTO(entity);
        }

        public async Task<TDTO> FindAsync(TKey id)
        {
            var entity = await Store.FindAsync(id);
            return ToDTO(entity);
        }

        public bool Remove(TKey id)
        {
            return Store.Remove(id);
        }

        public Task<bool> RemoveAsync(TKey id)
        {
            return Store.RemoveAsync(id);
        }

        public TDTO Update(TUpdateDTO updateDTO)
        {
            var entity = ToEntity(updateDTO);
            return ToDTO(Store.Update(entity));
        }

        public TDTO Update(TKey id, params (string Field, object Value)[] selectors)
        {
            return ToDTO(Store.Update(id, selectors));
        }

        public async Task<TDTO> UpdateAsync(TUpdateDTO updateDTO)
        {
            var entity = await Store.UpdateAsync(ToEntity(updateDTO));
            return ToDTO(entity);
        }

        public async Task<TDTO> UpdateAsync(TKey id, params (string Field, object Value)[] selectors)
        {
            var entity = await Store.UpdateAsync(id, selectors);
            return ToDTO(entity);
        }

        public async Task<(List<TDTO> List, long Total)> PageQuery(int pageIndex, int pageSize, params (string Field, bool IsAsc)[] sortFields)
        {
            var paged = await Store.PageQuery(s => true, sortFields, pageIndex, pageSize);

            return (
                paged.Entities.Select(s => ToDTO(s)).ToList(),
                paged.Total
                );
        }
    }
}
