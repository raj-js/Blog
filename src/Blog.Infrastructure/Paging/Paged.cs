using AutoMapper;
using System.Collections.Generic;

namespace Blog.Infrastructure.Paging
{
    public class Paged<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> Entities { get; set; }

        public int Total { get; set; }
    }
}
