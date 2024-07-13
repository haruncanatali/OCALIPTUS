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
    public class AppointmentDocumentConfiguration : IEntityTypeConfiguration<AppointmentDocument>
    {
        public void Configure(EntityTypeBuilder<AppointmentDocument> builder)
        {
            builder.Property(c => c.Path)
                .HasMaxLength(300)
                .IsRequired();
            builder.Property(c => c.AppointmentId)
                .IsRequired();
        }
    }
}
