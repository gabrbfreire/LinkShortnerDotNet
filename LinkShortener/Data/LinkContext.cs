using LinkShortener.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortener.Data
{
    public class LinkContext : DbContext
    {
        public LinkContext(DbContextOptions<LinkContext> options) : base (options)
        {

        }

        public DbSet<Link> Links { get; set; }
    }
}
