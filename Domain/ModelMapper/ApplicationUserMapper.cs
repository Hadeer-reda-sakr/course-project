using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelMapper
{
    public class ApplicationUserMapper
    {
        public ApplicationUserMapper(EntityTypeBuilder<ApplicationUser> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);


            entityTypeBuilder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            entityTypeBuilder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            entityTypeBuilder.Property(x => x.Name).IsRequired();
            entityTypeBuilder.Property(x => x.MobileNumber).IsRequired();
            entityTypeBuilder.Property(x => x.Email).IsRequired();
            entityTypeBuilder.Property(x => x.ProfilImage).IsRequired();
            entityTypeBuilder.Property(x => x.UserName).IsRequired();
            entityTypeBuilder.Property(x => x.Password).IsRequired();
            entityTypeBuilder.Property(x => x.InActive).IsRequired();
            entityTypeBuilder.Property(x => x.CourseName).IsRequired();
            entityTypeBuilder.Property(x => x.CourseId).IsRequired();




            entityTypeBuilder.HasOne(x => x.Courses).WithMany(t => t.StudentCourses);


        }

    }
}
