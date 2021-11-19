namespace ReactAspProject.Database
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DataContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}