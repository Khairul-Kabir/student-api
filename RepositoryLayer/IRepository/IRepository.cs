using DomainLayer.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.IRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete (T entity);
        T GetbyId(int Id);
        IEnumerable<T> GetAll();
        void SaveChanges();
    }

}
