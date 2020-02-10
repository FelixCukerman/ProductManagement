using ProductManagement.DataAccess.Models.Entities.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.Repositories.Base
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {
        Task<T> FindById(int id);
        Task<List<T>> GetAll();
        Task<int> GetCount();
        Task Delete(T item);
        Task DeleteRange(List<T> list);
        Task Delete(int id);
        Task DeleteRange(List<int> idList);
        Task Update(T item);
        Task UpdateRange(List<T> list);
        Task Insert(T item);
        Task InsertRange(List<T> list);
        Task<int> InsertAndReturnId(T item);
    }
}
