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
    class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("GestProject.Tickets");

            builder.Property(t => t.CreatedAt).IsRequired();
            builder.Property(t => t.State).IsRequired();
            builder.Property(t => t.Title).IsRequired().HasMaxLength(255);

        }
    }
}
