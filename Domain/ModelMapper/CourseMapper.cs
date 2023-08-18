using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelMapper
{

    public class CourseMapper
    {
        public CourseMapper(EntityTypeBuilder<Course> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Title).IsRequired();
            entityTypeBuilder.Property(x => x.Appointment).IsRequired();
            entityTypeBuilder.Property(x => x.Details);


        }
    }
}
