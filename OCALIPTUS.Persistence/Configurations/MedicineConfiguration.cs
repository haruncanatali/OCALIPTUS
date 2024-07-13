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
    public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(c => c.Piece)
                .IsRequired();
            builder.Property(c=>c.UntilIsOver)
                .HasDefaultValue(false)
                .IsRequired();
            builder.Property(c => c.MedicineFrequency)
                .IsRequired();
            builder.Property(c => c.AppointmentId)
                .IsRequired();
        }
    }
}
