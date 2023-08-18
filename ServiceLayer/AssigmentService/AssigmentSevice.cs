using Domain.Models;
using presentence.Repository;

namespace ServiceLayer.AssigmentService
{
    public class AssigmentSevice
    {
        public class AssigmentService : IAssigmentService
        {
            private IRepository<Assigment> _assignmentRepository;

            public AssigmentService(IRepository<Assigment> assignmentRepository)
            {
                this._assignmentRepository = assignmentRepository;
            }

            public IEnumerable<Assigment> GetAssignments()
            {
                return _assignmentRepository.GetAll();
            }

            public Assigment GetAssignment(long id)
            {
                return _assignmentRepository.Get(id);
            }

            public void InsertAssignment(Assigment assignment)
            {
                _assignmentRepository.Insert(assignment);
            }
            public void UpdateAssignment(Assigment assignment)
            {
                _assignmentRepository.Update(assignment);
            }

            public void DeleteAssignment(long id)
            {
                Assigment assignment = GetAssignment(id);
                _assignmentRepository.Remove(assignment);
                _assignmentRepository.Save();
            }
        }
    }
}
