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
    class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("GestProject.Users");

            builder.Property(u => u.Email).IsRequired().HasMaxLength(255);
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.Salt).IsRequired();
            builder.HasIndex(u => u.Salt).IsUnique();

            builder.Property(u => u.Passwd).IsRequired();

            builder.Property(u => u.Role).IsRequired();
        }
    }
}
