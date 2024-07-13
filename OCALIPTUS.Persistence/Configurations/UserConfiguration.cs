using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(c => c.FirstName)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(c => c.Surname)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(c => c.ProfilePhoto)
                .HasMaxLength(300)
                .IsRequired();
            builder.Property(c => c.Birthdate)
                .IsRequired();
            builder.Property(c => c.Age)
                .IsRequired();
            builder.Property(c => c.IdentityNumber)
                .HasMaxLength(11)
                .IsFixedLength()
                .IsRequired();
            builder.Property(c => c.Gender)
                .IsRequired();
            builder.Property(c => c.Nationality)
                .IsRequired();
            builder.Property(c => c.MemberStatus)
                .IsRequired();
        }
    }
}
