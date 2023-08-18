using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.models
{
    public class Assigment : BaseEntity
    {
        // class Assigment properties 

        
        [DataType(DataType.Date)]
        public DateTime DeadLine { get; set; }

        public string Material { get; set; }

        public string Description { get; set; }

        //foreignkey property 

        
        public int SessionId { get; set; }

        // Navigation property

        public ICollection<StudentAssigment> StudentAssigments { get; set; }

        public Session Session { get; set; }


    }
}
