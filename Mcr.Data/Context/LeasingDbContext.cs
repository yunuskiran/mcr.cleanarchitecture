using Mcr.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mcr.Data.Context
{
    public class LeasingDbContext
        : DbContext
    {
        public LeasingDbContext(DbContextOptions<LeasingDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<Leasing> Leasings { get; set; }
    }
}
