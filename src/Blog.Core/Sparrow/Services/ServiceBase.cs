using AutoMapper;
using Blog.Core.Sparrow.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Sparrow.Services
{
    public abstract class ServiceBase
        <
        TEntity, TKey,
        TCreateReqDto, TUpdateReqDto,
        TRespDto
        > :

        ICreateService<TEntity, TKey, TCreateReqDto, TRespDto>,
        IRemoveService<TEntity, TKey>,
        IUpdateService<TEntity, TKey, TUpdateReqDto, TRespDto>,
        IQueryService<TEntity, TKey, TRespDto>,
        ICurlService
        <
        TEntity, TKey,
        TCreateReqDto, TUpdateReqDto,
        TRespDto
        >

        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        protected IMapper Mapper { get; private set; }
        private readonly ICurlStore<TEntity, TKey> _store;

        public ServiceBase(IMapper mapper, ICurlStore<TEntity, TKey> store)
        {
            Mapper = mapper;
            _store = store;
        }

        #region protected

        protected virtual TEntity ToEntity(object req) => Mapper.Map<TEntity>(req);
        protected virtual TRespDto ToRespDto(TEntity entity) => Mapper.Map<TRespDto>(entity);

        #endregion

        public long Count()
        {
            return _store.Count();
        }

        public Task<long> CountAsync()
        {
            return _store.CountAsync();
        }

        public TRespDto Create(TCreateReqDto reqDto)
        {
            var entity = _store.Create(ToEntity(reqDto));
            return ToRespDto(entity);
        }

        public TKey CreateAndGetId(TCreateReqDto reqDto)
        {
            return _store.CreateAndGetId(ToEntity(reqDto));
        }

        public Task<TKey> CreateAndGetIdAsync(TCreateReqDto reqDto)
        {
            return _store.CreateAndGetIdAsync(ToEntity(reqDto));
        }

        public async Task<TRespDto> CreateAsync(TCreateReqDto reqDto)
        {
            var entity = await _store.CreateAsync(ToEntity(reqDto));
            return ToRespDto(entity);
        }

        public void CreateMany(IEnumerable<TCreateReqDto> reqDtos)
        {
            var entities = reqDtos.Select(s => ToEntity(s));
            _store.CreateMany(entities);
        }

        public Task CreateManyAsync(IEnumerable<TCreateReqDto> reqDtos)
        {
            var entities = reqDtos.Select(s => ToEntity(s));
            return _store.CreateManyAsync(entities);
        }

        public TRespDto Find(TKey id)
        {
            var entity = _store.Find(id);
            return ToRespDto(entity);
        }

        public async Task<TRespDto> FindAsync(TKey id)
        {
            var entity = await _store.FindAsync(id);
            return ToRespDto(entity);
        }

        public bool Remove(TKey id)
        {
            return _store.Remove(id);
        }

        public Task<bool> RemoveAsync(TKey id)
        {
            return _store.RemoveAsync(id);
        }

        public TRespDto Update(TUpdateReqDto reqDto)
        {
            var entity = ToEntity(reqDto);
            return ToRespDto(_store.Update(entity));
        }

        public TRespDto Update(TKey id, params (string Field, object Value)[] selectors)
        {
            return ToRespDto(_store.Update(id, selectors));
        }

        public async Task<TRespDto> UpdateAsync(TUpdateReqDto reqDto)
        {
            var entity = await _store.UpdateAsync(ToEntity(reqDto));
            return ToRespDto(entity);
        }

        public async Task<TRespDto> UpdateAsync(TKey id, params (string Field, object Value)[] selectors)
        {
            var entity = await _store.UpdateAsync(id, selectors);
            return ToRespDto(entity);
        }
    }
}
