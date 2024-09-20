using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FiberFinance.Models;

namespace FiberFinance.Data
{
    public class FiberFinanceContext : DbContext
    {
        public FiberFinanceContext (DbContextOptions<FiberFinanceContext> options)
            : base(options)
        {
        }

        public DbSet<FiberFinance.Models.RawMaterial> RawMaterial { get; set; } = default!;
        public DbSet<FiberFinance.Models.Product> Product { get; set; } = default!;
       
      
    }
}
