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

        public DbSet<Address> Addresses { get; set; }

        public DbSet<SeminarItem> SeminarItems { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
