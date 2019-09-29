using Blog.Core.Models;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Application.IServices
{
    public interface IArticleService
    {
        Task<IEnumerable<Article>> Query();

        Task<Article> SingleById(ObjectId id);

        Task<Article> Create(Article article);

        Task<Article> Modify(Article article);

        Task Delete(ObjectId id);
    }
}
