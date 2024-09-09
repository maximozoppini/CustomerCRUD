using SimpleCRUD.Entities;
using SimpleCRUD.Entities.DBContext;
using SimpleCRUD.Repositories.Interfaces;

namespace SimpleCRUD.Repositories
{
    public abstract class Repository<T, Int> : IRepository<T, Int> where T : BaseEntity
    {
        protected readonly CustomerAssestmentContext _context;
        protected Repository(CustomerAssestmentContext context)
        {
            _context = context;
        }
        public async Task<T> Add(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync(true);
            return entity;
        }

        public Task<T> Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
