using Domain.models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.modelMapper
{
    public class AttendanceMapper
    {
        public AttendanceMapper(EntityTypeBuilder<Attendance> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.IsAttended).IsRequired();


            entityTypeBuilder.HasKey(o => new { o.SessionId, o.StudentId});

            entityTypeBuilder.HasOne(x => x.Session).WithMany(x => x.AttendanceSession);
        }
    }
}
