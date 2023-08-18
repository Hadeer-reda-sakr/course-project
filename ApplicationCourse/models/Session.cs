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
    public class Session : BaseEntity
    {
        // class Session properties



        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Material { get; set; }


        // foreignKey property

        
        public int? CourseId { get; set; }



        //Navigation Property

        public Course Course { get; set; }
        public ICollection<Attendance> AttendanceSession { get; set; }
        public ICollection<Assigment> assigments { get; set; }


    }
}
