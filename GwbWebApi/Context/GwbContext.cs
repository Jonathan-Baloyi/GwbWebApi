using GwbWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GwbWebApi.Context
{
    public class GwbContext : DbContext
    {
        public GwbContext(DbContextOptions<GwbContext> options)
            : base(options)
        { }

        public DbSet<ContactUs> ContactUs { get; set; }

    }
}
