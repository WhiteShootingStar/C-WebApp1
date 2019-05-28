using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Site.Models
{
    public class SiteContext : DbContext
    {
        public SiteContext (DbContextOptions<SiteContext> options)
            : base(options)
        {
        }

        public DbSet<Site.Models.Movie> Movie { get; set; }
    }
}
