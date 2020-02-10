using ProductManagement.DataAccess.Models.Entities;
using ProductManagement.DataAccess.Models.RequestModels;
using ProductManagement.DataAccess.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.Repositories.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<List<Product>> GetByRequest(RequestGetProductsModel request);
    }
}
