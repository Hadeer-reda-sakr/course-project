using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Domain.Models
{
    public class Attendance : BaseEntity
    {
        // class Attendance properties



        [DefaultValue(true)]
        public bool IsAttended { get; set; } = true;

        // foreignKey property 


        public int StudentId { get; set; }

    public ApplicationUser Student { get; set; }

        public int SessionId { get; set; }


        // Navigation property

        public Session Session { get; set; }
       // public ICollection<ApplicationUser> students { get; set; }

       



    }
}
