using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubicon_Admin.DataAccess.Croe.Interfaces.DbContext;
using Rubicon_Admin.DataAccess.Croe.Models;
using System.Threading;

namespace Rubicon_Admin.DataAccess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options) : base(options) 
            {

            }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
