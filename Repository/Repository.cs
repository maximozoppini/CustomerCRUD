using Microsoft.EntityFrameworkCore;
using SimpleCRUD.Entities;
using SimpleCRUD.Entities.DBContext;
using SimpleCRUD.Repositories.Interfaces;
using System.Linq.Expressions;

namespace SimpleCRUD.Repositories
{
    public abstract class BaseRepository<T, Int> : IRepository<T, Int> where T : BaseEntity
    {
        protected readonly CustomerAssestmentContext _context;
        private readonly DbSet<T> _dbSet;

        protected BaseRepository(CustomerAssestmentContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync(true);
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync(true);
            return entity;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}
