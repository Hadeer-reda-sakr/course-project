using Domain.models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.modelMapper
{
    public class SessionMapper
    {

        
            public SessionMapper(EntityTypeBuilder<Session> entityTypeBuilder)
            {
                entityTypeBuilder.HasKey(x => x.Id);
                entityTypeBuilder.Property(x => x.Date).IsRequired();
                entityTypeBuilder.HasOne(x => x.Course).WithMany(x => x.Sessions);
            }
       
    }
}
