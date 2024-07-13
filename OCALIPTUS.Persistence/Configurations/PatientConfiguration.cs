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
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.Property(c => c.Photo)
                .HasMaxLength(300)
                .IsRequired();
            builder.Property(c => c.Description)
                .HasMaxLength(5000)
                .HasDefaultValue("Hasta açıklaması bulunamadı.")
                .IsRequired();
            builder.Property(c => c.UserId)
                .IsRequired();
        }
    }
}
