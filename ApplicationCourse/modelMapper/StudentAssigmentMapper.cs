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
    public class StudentAssigmentMapper
    {

        public StudentAssigmentMapper(EntityTypeBuilder<StudentAssigment> entityTypeBuilder)
        
        {
            entityTypeBuilder.Property(x => x.Evaluation).IsRequired();

            entityTypeBuilder.Property(x => x.Solution).IsRequired();

            
       entityTypeBuilder.HasOne(x => x.Students).WithMany(t => t.StudentAssigments);

            entityTypeBuilder.HasOne(x => x.Assigment).WithMany(t => t.StudentAssigments);
            /*-- composed key for entity student Assigment --*/

            entityTypeBuilder.HasKey(o => new { o.AssigmentId, o.StudentId });
            

        }
    }
}
