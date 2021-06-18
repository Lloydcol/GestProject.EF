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
    class WorkOnConfig : IEntityTypeConfiguration<WorkOn>
    {
        public void Configure(EntityTypeBuilder<WorkOn> builder)
        {
            builder.ToTable("GestProject.WorkOn");
        }
    }
}
