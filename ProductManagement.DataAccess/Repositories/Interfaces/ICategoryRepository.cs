using ProductManagement.DataAccess.Models.Entities;
using ProductManagement.DataAccess.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.Repositories.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<List<Category>> GetByIds(IEnumerable<int> ids);
        Task<string> GetNameById(int id);
    }
}
