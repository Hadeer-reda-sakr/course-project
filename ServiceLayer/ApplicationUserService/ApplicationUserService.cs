//using Domain.Models;
//using presentence.Repository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ServiceLayer.ApplicationUserService
//{
//    public class ApplicationUserService : IApplicationUserService
//    {
//        private IRepository<ApplicationUser> _StudentRepository;

//        public ApplicationUserService(IRepository<ApplicationUser> StudentRepository)
//        {
//            this._StudentRepository = StudentRepository;


//        }

//        public IEnumerable<ApplicationUser> GetUsers()
//        {
//            return _StudentRepository.GetAll();
//        }

//        public ApplicationUser GetStudent(long id)
//        {

//            return _StudentRepository.Get(id);
//        }

//        public void InsertStudent(ApplicationUser student)
//        {
//            _StudentRepository.Insert(student);
//        }

//        public void UpdateStudent(ApplicationUser student)
//        {
//            _StudentRepository.Update(student);



//        }

//        public void DeleteStudent(long id)
//        {


//            ApplicationUser student = GetStudent(id);
//            _StudentRepository.Delete(student);
//            _StudentRepository.Save();

//        }

//    }
//}
