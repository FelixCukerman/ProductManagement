using Microsoft.EntityFrameworkCore;
using ProductManagement.DataAccess.DataAccept;
using ProductManagement.DataAccess.Models.Entities.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.Repositories.Base
{
    public abstract class EFBaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        #region Properties
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;
        #endregion

        #region Constructors
        public EFBaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        #endregion

        #region Public Methods
        public async Task Delete(T requestedItem)
        {
            if (requestedItem is null)
            {
                return;
            }

            T item = await _dbSet.FindAsync(requestedItem);

            if (item is null)
            {
                return;
            }

            var dbEntry = _context.Entry(item);
            dbEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            if (id.Equals(default(int)))
            {
                return;
            }

            T item = await _dbSet.FindAsync(id);

            if (item is null)
            {
                return;
            }

            var dbEntry = _context.Entry(item);
            dbEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteRange(List<T> list)
        {
            if (list is null || !list.Any())
            {
                return;
            }

            _dbSet.RemoveRange(list);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteRange(List<int> idList)
        {
            if (idList is null || !idList.Any())
            {
                return;
            }

            var removeItemsList = new List<T>();

            for (int i = 0; i < idList.Count(); i++)
            {
                T item = await _dbSet.FindAsync(idList[i]);

                if (item is null)
                {
                    continue;
                }

                removeItemsList.Add(item);
            }

            _dbSet.RemoveRange(removeItemsList);

            await _context.SaveChangesAsync();
        }

        public async Task<T> FindById(int id)
        {
            T item = await _dbSet.FindAsync(id);

            return item;
        }

        public async Task<List<T>> GetAll()
        {
            List<T> items = await _dbSet.ToListAsync();

            return items;
        }

        public async Task<int> GetCount()
        {
            int result = await _dbSet.CountAsync();

            return result;
        }

        public async Task Insert(T item)
        {
            if (item is null)
            {
                return;
            }

            _dbSet.Add(item);

            await _context.SaveChangesAsync();
        }

        public async Task<int> InsertAndReturnId(T item)
        {
            if (item is null)
            {
                return default(int);
            }

            _dbSet.Add(item);

            await _context.SaveChangesAsync();
            return item.Id;
        }

        public async Task InsertRange(List<T> list)
        {
            if (list is null)
            {
                return;
            }

            _dbSet.AddRange(list);

            await _context.SaveChangesAsync();
        }

        public async Task Update(T item)
        {
            if (item is null)
            {
                return;
            }

            _dbSet.Update(item);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateRange(List<T> list)
        {
            if (list is null || !list.Any())
            {
                return;
            }

            _dbSet.UpdateRange(list);

            await _context.SaveChangesAsync();
        }
        #endregion
    }
}