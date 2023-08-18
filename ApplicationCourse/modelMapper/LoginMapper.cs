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
    public class LoginMapper
    {
        public LoginMapper(EntityTypeBuilder<Login> entityTypeBuilder)
        {
            entityTypeBuilder.Property(x => x.Password).IsRequired();

            entityTypeBuilder.Property(x => x.Email).IsRequired().HasColumnName("Email Or UserName");

            entityTypeBuilder.Property(x => x.RememberMe).HasColumnName("Remember Me");
        }
    }
}
