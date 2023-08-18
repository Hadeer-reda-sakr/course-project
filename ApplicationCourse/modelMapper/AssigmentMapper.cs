using Domain.models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.modelMapper
{
    public class AssigmentMapper
    {
        public AssigmentMapper(EntityTypeBuilder<Assigment> EntityBuilder)
        {
            EntityBuilder.Property(t => t.Material);
            EntityBuilder.Property(t => t.DeadLine).IsRequired();
            EntityBuilder.Property(t => t.SessionId);
            EntityBuilder.Property(t => t.Description);
            EntityBuilder.HasOne(x => x.Session).WithMany(x => x.assigments).HasForeignKey(x => x.SessionId);


        }
    }
}
