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
    class ColumnConfig : IEntityTypeConfiguration<Column>
    {
        public void Configure(EntityTypeBuilder<Column> builder)
        {
            builder.ToTable("GestProject.Columns");

            builder.Property(c => c.Title).IsRequired();

            // Rel o-n avec Ticket
            builder.HasMany(c => c.Tickets).WithOne(t => t.Column);
        }
    }
}
