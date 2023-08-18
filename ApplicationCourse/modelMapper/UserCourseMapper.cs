using Domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.modelMapper
{
    public class UserCourseMapper
    {
        public UserCourseMapper(EntityTypeBuilder<UserCourse> entityTypeBuilder)
        
        {
            /*-- composed key for entity student Course --*/
            entityTypeBuilder.HasKey(o => new { o.StudentId, o.CourseId });


            entityTypeBuilder.HasOne(x => x.Students).WithMany(t => t.StudentCourses);

            entityTypeBuilder.HasOne(x => x.Course).WithMany(t => t.StudentCourses);
        }
    }
}
