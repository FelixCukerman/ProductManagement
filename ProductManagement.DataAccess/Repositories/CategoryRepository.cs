using Microsoft.EntityFrameworkCore;
using ProductManagement.DataAccess.DataAccept;
using ProductManagement.DataAccess.Models.Entities;
using ProductManagement.DataAccess.Repositories.Base;
using ProductManagement.DataAccess.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.Repositories
{
    public class CategoryRepository : EFBaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Category>> GetByIds(IEnumerable<int> ids)
        {
            List<Category> categories = await _context.Categories.Where(item => ids.Contains(item.Id)).ToListAsync();

            return categories;
        }

        public async Task<string> GetNameById(int id)
        {
            string name = string.Empty;

            Category category = await _context.Categories.FirstOrDefaultAsync(item => item.Id == id);

            if(category != null)
            {
                name = category.Name;
            }

            return name;
        }
    }
}
