using System;

namespace Blog.Core.Sparrow.Services
{
    public interface ICurlService
        <
        TEntity, TKey,
        TReqDto,
        TCreateReqDto, TUpdateReqDto,
        TRespDto
        > :
        ICreateService<TEntity, TKey, TCreateReqDto, TRespDto>,
        IRemoveService<TEntity, TKey, TReqDto>,
        IUpdateService<TEntity, TKey, TUpdateReqDto, TRespDto>,
        IQueryService<TEntity, TKey, TReqDto, TRespDto>

        where TEntity : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {

    }
}
