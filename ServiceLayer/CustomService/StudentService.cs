using DomainLayer.EF.EntityModel;
using RepositoryLayer.IRepository;
using ServiceLayer.ICustomService;

namespace ServiceLayer.CustomService
{
    public class StudentService : ICustomService<Student>
    {
        private readonly IRepository<Student> _studentRepository;
        public StudentService(IRepository<Student> studentRepository)
        {

            _studentRepository = studentRepository;

        }
        public void Delete(Student entity)
        {
            try
            {
                if (entity != null)
                {
                    _studentRepository.Delete(entity);
                    _studentRepository.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student Get(int Id)
        {
            try
            {
                return _studentRepository.GetbyId(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Student> GetAll()
        {
            try
            {
                return _studentRepository.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Insert(Student entity)
        {
            try
            {
                if (entity != null)
                {
                    entity.StudentUniqueId = new Guid();
                    entity.CreatedBy = new Guid();
                    entity.CreatedDate = DateTime.Now;
                    _studentRepository.Add(entity);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Remove(Student entity)
        {
            try
            {
                if (entity != null)
                {
                    _studentRepository.Delete(entity);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Student entity)
        {
            try
            {
                if (entity != null)
                {
                    entity.UpdateBy = new Guid();
                    entity.UpdatedDate = DateTime.Now;
                    _studentRepository.Update(entity);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
