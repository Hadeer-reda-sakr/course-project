using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.models
{
    public class Attendance : BaseEntity
    {
        // class Attendance properties



        [DefaultValue(true)]
        public bool IsAttended { get; set; } = true;

        // foreignKey property 

        
        public int? StudentId { get; set; }


       
        public int? SessionId { get; set; }


        // Navigation property

        public Session Session { get; set; }
        public ICollection<ApplicationUser> students { get; set; }

        public ApplicationUser student { get; set; }



    }
}
