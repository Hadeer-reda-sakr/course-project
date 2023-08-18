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
    public class ApplicationUserMapper
    {
        public ApplicationUserMapper(EntityTypeBuilder<ApplicationUser> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);


            entityTypeBuilder.Property(x=>x.FirstName).IsRequired().HasMaxLength(100);
            entityTypeBuilder.Property(x=>x.LastName).IsRequired().HasMaxLength(100);
            entityTypeBuilder.Property(x=>x.Name).IsRequired().HasColumnName("Full Name");
            entityTypeBuilder.Property(x => x.MobileNumber).IsRequired().HasColumnName("Mobile Number");
            entityTypeBuilder.Property(x => x.Email).IsRequired();
            entityTypeBuilder.Property(x => x.ProfilImage).IsRequired();
            entityTypeBuilder.Property(x => x.UserName).IsRequired().HasColumnName("User Name");
            entityTypeBuilder.Property(x => x.Password).IsRequired();
            entityTypeBuilder.Property(x => x.InActive) .IsRequired();
            entityTypeBuilder.Property(x => x.CourseName).IsRequired().HasColumnName("Course Name");


            entityTypeBuilder.HasOne(x => x.attendance).WithOne(t => t.student).HasForeignKey<Attendance>(v => v.Id);
            
            



        }

    }
}
