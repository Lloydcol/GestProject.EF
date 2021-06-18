using GestProject.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProject.EF.Configs
{
    class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("GestProject.Projects");

            builder.Property(p => p.Title).IsRequired().HasMaxLength(255);

            builder.Property(p => p.CreatedAt).IsRequired();

            // Rel Projet - Columns
            builder.HasMany(p => p.Columns).WithOne(c => c.Project);
        }
    }
}
