using Microsoft.EntityFrameworkCore;
using SeminarMnagamenet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarManagement.Database.EFCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Seminar> Seminars { get; set; }

        public DbSet<Lectur> Lecturs { get; set; }

        public DbSet<ConfrenceRome> ConfrenceRomes { get; set; }
    }
}
