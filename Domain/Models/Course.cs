using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Domain.Models
{
    public class Course : BaseEntity
    {
        // class Course properties


        [MinLength(2, ErrorMessage = "This field must be at least 2 characters long")]
        public string Title { get; set; }

        public string Appointment { get; set; }

        public string Details { get; set; }

        // Navigation property

        public ICollection<Session> Sessions { get; set; }

       // public ApplicationUser Students { get; set; }

        public ICollection<ApplicationUser> StudentCourses { get; set; }
        


    }
}
