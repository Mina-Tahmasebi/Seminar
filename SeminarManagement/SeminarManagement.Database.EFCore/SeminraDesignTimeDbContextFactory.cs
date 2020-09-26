using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarManagement.Database.EFCore
{
    public class SeminraDesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseSqlServer("Data Source=localhost;Initial Catalog=SeminarDb;Integrated Security=True");

            return new AppDbContext(builder.Options);
        }
    }
}
