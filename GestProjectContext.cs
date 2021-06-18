using GestProject.EF.Configs;
using GestProject.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProject.EF
{
    public class GestProjectContext: DbContext
    {
        private readonly string _defaultConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestProject;Integrated Security=True";

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<WorkOn> WorkOn { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_defaultConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new ProjectConfig());
            builder.ApplyConfiguration(new ColumnConfig());
            builder.ApplyConfiguration(new TicketConfig());
            builder.ApplyConfiguration(new WorkOnConfig());
            builder.ApplyConfiguration(new CommentConfig());
        }
    }
}
