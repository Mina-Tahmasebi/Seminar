using Microsoft.EntityFrameworkCore;
using Seminar.Model;
using System;

namespace Seminar.Database
{
    public class SeminarDbContext : DbContext
    {
        public SeminarDbContext()
        {

        }

        public DbSet<Dogh> Doghs { get; set; }
    }
}
