
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarManagement.Api
{
    public class ApplicationDbContext:DbContext
    {
        public  ApplicationDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Topic> topics { get; set; }
        public DbSet<SeminarItem> SeminarItems { get; set; }
        public DbSet<Visitor> Visitors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


    }
}
