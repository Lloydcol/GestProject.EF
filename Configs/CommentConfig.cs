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
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("GestProject.Comments");

            builder.Property(c => c.CreatedAt).IsRequired();
            builder.Property(c => c.TicketId).IsRequired();
            builder.Property(c => c.Text).IsRequired().HasMaxLength(255);
        }
    }
}
