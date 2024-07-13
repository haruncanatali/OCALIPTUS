using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OCALIPTUS.Domain.Entities;

namespace OCALIPTUS.Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(c => c.Title)
                .HasMaxLength(150)
                .IsRequired();
            builder.Property(c => c.City)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(c => c.Country)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(c => c.Province)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(c => c.Street)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(c => c.PostalCode)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(c => c.Description)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
