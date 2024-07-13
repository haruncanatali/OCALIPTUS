using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OCALIPTUS.Domain.Entities;

namespace OCALIPTUS.Persistence.Configurations
{
    public class DiagnosisConfiguration : IEntityTypeConfiguration<Diagnosis>
    {
        public void Configure(EntityTypeBuilder<Diagnosis> builder)
        {
            builder.Property(c => c.Description)
                .HasMaxLength(5000)
                .HasDefaultValue("Tanı bulunamadı.")
                .IsRequired();
            builder.Property(c => c.DiagnosisType)
                .IsRequired();
            builder.Property(c => c.AppointmentId)
                .IsRequired();
        }
    }
}
