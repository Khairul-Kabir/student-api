using DomainLayer.Data;
using DomainLayer.EF.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepository;

namespace RepositoryLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity 
    {
        private readonly SchoolDbContext _context;
        private readonly DbSet<T> entities;
        public Repository(SchoolDbContext schoolDbContext)
        {
            _context = schoolDbContext;
            entities = _context.Set<T>();
        }
        public void Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            else
                entities.Add(entity);
                _context.SaveChanges();

        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            else
                entities.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetbyId(int Id) 
        {
            return entities.SingleOrDefault(s => s.Id == Id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            else
                entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
