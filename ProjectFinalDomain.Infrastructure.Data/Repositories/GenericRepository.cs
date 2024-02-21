using ProjectFinalDemo.Domain.Repositories;
using ProjectFinalDomain.Infrastructure.Data.Data;

namespace ProjectFinalDomain.Infrastructure.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            _context.Set<T>().AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = GetByIdAsync(id);
            _context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByIdAsync(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
    }
}
