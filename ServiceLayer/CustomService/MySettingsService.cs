using DomainLayer.EF.EntityModel;
using RepositoryLayer.IRepository;
using ServiceLayer.ICustomService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CustomService
{
    public class MySettingsService : ICustomService<UserOutOfOffice>
    {
        private readonly IRepository<UserOutOfOffice> _repository;
        public MySettingsService(IRepository<UserOutOfOffice> repository)
        {
            _repository = repository;
        }
        public void Delete(UserOutOfOffice entity)
        {
            throw new NotImplementedException();
        }

        public UserOutOfOffice Get(int Id)
        {
            return _repository.GetbyId(Id);
        }

        public IEnumerable<UserOutOfOffice> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(UserOutOfOffice entity)
        {
            try
            {
                _repository.Add(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Remove(UserOutOfOffice entity)
        {
            throw new NotImplementedException();
        }

        public void Update(UserOutOfOffice entity)
        {
            throw new NotImplementedException();
        }
    }
}
