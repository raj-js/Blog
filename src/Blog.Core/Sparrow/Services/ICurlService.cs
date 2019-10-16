using System;

namespace Blog.Core.Sparrow.Services
{
    public interface ICurlService
        <
        TEntity, TKey,
        TCreateReqDto, TUpdateReqDto,
        TRespDto
        > :
        ICreateService<TEntity, TKey, TCreateReqDto, TRespDto>,
        IRemoveService<TEntity, TKey>,
        IUpdateService<TEntity, TKey, TUpdateReqDto, TRespDto>,
        IQueryService<TEntity, TKey, TRespDto>

        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {

    }
}
