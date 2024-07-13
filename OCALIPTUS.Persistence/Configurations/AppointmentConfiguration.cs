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
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.Property(c => c.StaffId)
                .IsRequired();
            builder.Property(c => c.PatientId)
                .IsRequired();
            builder.Property(c => c.Date)
                .IsRequired();
            builder.Property(c => c.Hour)
                .HasMaxLength(5)
                .IsRequired();
            builder.Property(c => c.EntityStatus)
                .IsRequired();
        }
    }
}
