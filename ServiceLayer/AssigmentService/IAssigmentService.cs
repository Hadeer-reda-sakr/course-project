using Domain.Models;

namespace ServiceLayer.AssigmentService
{
    public interface IAssigmentService
    {
        IEnumerable<Assigment> GetAssignments();
        Assigment GetAssignment(long id);
        void InsertAssignment(Assigment assignment);
        void UpdateAssignment(Assigment assignment);
        void DeleteAssignment(long id);
    }
}