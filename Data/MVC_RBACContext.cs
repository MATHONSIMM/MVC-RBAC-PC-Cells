using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MappingList.Models;

namespace MVC_RBAC.Data
{
    public class MVC_RBACContext : DbContext
    {
        public MVC_RBACContext (DbContextOptions<MVC_RBACContext> options)
            : base(options)
        {
        }

        public DbSet<MappingList.Models.PerformanceCellsUpdated> PerformanceCellsUpdated { get; set; } = default!;
    }
}
