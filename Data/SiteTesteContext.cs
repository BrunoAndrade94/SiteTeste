using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteTeste.Models
{
    public class SiteTesteContext : DbContext
    {
        public SiteTesteContext (DbContextOptions<SiteTesteContext> options)
            : base(options)
        {
        }

        public DbSet<SiteTeste.Models.Department> Department { get; set; }
    }
}
