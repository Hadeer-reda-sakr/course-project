using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Management;

namespace Web.ViewModel
{
    public class CourseViewModel

    {
        public int Id { get; set; }

        [MinLength(2, ErrorMessage = "This field must be at least 2 characters long")]
        public string Title { get; set; }

        public string Appointment { get; set; }

        public string Details { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ModifiedAt { get; set; } = DateTime.Now;

        public int? ModifiedBy { get; set; }


        [DataType(DataType.Date)]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public int CreatedBy { get; set; }


        // public List<SelectListItem> Courses { get; set; }

        // public string[] course{ get; set; }

        //IEnumerable<CourseViewModel>  chooseCourses { get;set; }
    }
}
