using Microsoft.EntityFrameworkCore;
using Rubicon_Admin.DataAccess.Croe.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Rubicon_Admin.DataAccess.Croe.Interfaces.DbContext
{
    public interface IRubicContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        DbSet<UserRoleRto> UserRoles { get; set; }
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
    }
}
