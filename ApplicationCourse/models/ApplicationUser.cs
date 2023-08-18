using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.models
{
    public class ApplicationUser : BaseEntity 
    {
        // class student properties


       
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [MinLength(2, ErrorMessage = "This field must be at least 2 characters long")]
         public string Name { get; set; }

        [RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "Phone length is exactly 11\r\n\r\nPhone Prefix is with in allowed ones 010, 011, 012, 015\r\n")]
        public string MobileNumber { get; set; }

       
        [EmailAddress(ErrorMessage = "Invaild Email address")]
        public string Email { get; set; }

        
        public string ProfilImage { get; set; }

        [MinLength(2, ErrorMessage = "The first name field must be at least 2 characters long")]
        public string UserName { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8}$", ErrorMessage = "Password matching expression." +
            " Match all alphanumeric character and predefined wild characters. Password must consists of at least 8" +
            " characters and not more than 15 characters.\r\n ")]
        public string Password { get; set; }

        public bool InActive { get; set; } = false;

        public string CourseName { get; set; }


        public int? AttendanceId { get; set; }

        //Navigation Property

        public Attendance attendance { get; set; }

        public ICollection<UserCourse> StudentCourses { get; set; }
        public ICollection<StudentAssigment> StudentAssigments { get; set; }


    }
}

