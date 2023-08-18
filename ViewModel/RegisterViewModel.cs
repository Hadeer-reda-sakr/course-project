using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Web.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [Display(Name = "FristName")]
        public string FristName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "Phone length is exactly 11\r\n\r\nPhone Prefix is with in allowed ones 010, 011, 012, 015\r\n")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
        public string ConfirmPassword { get; set; }

        public string UserName { get; set; }

        public byte[] Profilepicture { get; set; }

        public bool InActive { get; set; }


        [Display(Name ="Course")]
        public byte CourseId { get; set; }

       public IEnumerable<Course>? Courses { get; set; }
    }
}
