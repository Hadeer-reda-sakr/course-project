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
    public class RegsiterMapper
    {
        public RegsiterMapper(EntityTypeBuilder<Regsiter> entityTypeBuilder)

        {
            entityTypeBuilder.Property(x => x.FristName).IsRequired().HasColumnName("Frist Name");

            entityTypeBuilder.Property(x => x.LastName).IsRequired().HasColumnName("Last Name");

            entityTypeBuilder.Property(x => x.Password).IsRequired();

            entityTypeBuilder.Property(x => x.Email).IsRequired();

            entityTypeBuilder.Property(x => x.ConfirmPassword).IsRequired().HasColumnName("Confirm Password");
        }
    }
}
