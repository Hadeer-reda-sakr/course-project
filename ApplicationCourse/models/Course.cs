using System.ComponentModel.DataAnnotations;

namespace Domain.models
{
    public class Course : BaseEntity
    {
        // class Course properties

        
        [MinLength(2, ErrorMessage = "This field must be at least 2 characters long")]
        public string Title { get; set; }

        public string Appointment { get; set; }



        // Navigation property

        public ICollection<Session> Sessions { get; set; }
        public ICollection<UserCourse> StudentCourses { get; set; }
        public ICollection<UserCourse> AdminCourses { get; set; }


    }
}
