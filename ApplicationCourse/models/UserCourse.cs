using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.models
{
    public class UserCourse
    {
        // class studentcourse property

 
        public int? StudentId { get; set; }

        
        public int? CourseId { get; set; }

        //Navigation Property

        public ApplicationUser Students { get; set; }
        public Course Course { get; set; }


    }
}
