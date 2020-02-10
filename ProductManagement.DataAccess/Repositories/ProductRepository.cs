using Microsoft.EntityFrameworkCore;
using ProductManagement.DataAccess.DataAccept;
using ProductManagement.DataAccess.Models.Entities;
using ProductManagement.DataAccess.Models.RequestModels;
using ProductManagement.DataAccess.Repositories.Base;
using ProductManagement.DataAccess.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.Repositories
{
    public class ProductRepository : EFBaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetByRequest(RequestGetProductsModel request)
        {
            List<Product> products = await _context.Products.Skip(request.Index).Take(request.Count).ToListAsync();

            return products;
        }
    }
}
