using Demo.DAL.Model;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Data.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {
            // Fluent APIs

            builder.Property(D => D.Id).UseIdentityColumn(10, 10);

            builder.HasMany(D => D.Employees)
                .WithOne(E => E.Department)
                .HasForeignKey(E => E.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(D => D.Code)
            .IsRequired(true);

            builder.Property(D => D.Name)
                .IsRequired(true)
                .HasMaxLength(20);
        }
    }
}
