using Blog.Core.Models;
using Blog.Infrastructure.Paging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    public interface IArticleService
    {
        Task<IEnumerable<Article>> QueryByCategory(Pager pager);
    }
}
