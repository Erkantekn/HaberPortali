using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public class PortalDbContext:DbContext
    {
        public PortalDbContext(DbContextOptions<PortalDbContext> options)
          : base(options) { }
        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }
}

