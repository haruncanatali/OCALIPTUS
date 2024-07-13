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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(150)
                .IsRequired();
            builder.Property(c => c.Description)
                .HasMaxLength(5000)
                .HasDefaultValue("Açıklama bulunamadı.")
                .IsRequired();
            builder.Property(c => c.Floor)
                .IsRequired();
            builder.Property(c => c.DepartmentType)
                .IsRequired();
            builder.Property(c => c.Photo)
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}
