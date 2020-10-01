using ProductsApi.Data.Entities;
using System.Threading.Tasks;

namespace ProductsApi.Services.DbService
{
    public interface IDbService<T> where T : BaseEntity
    {
        Task<T> Get(string id);
        Task<T[]> GetAll();
        Task<T> AddOneAsync(T item);
        Task<T> Update(T item);
        Task<T> ClearAll(string id);
    }
}