using IdentityServer.Admin.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Admin.EntityFramework.Interfaces
{
    public interface IAdminLogDbContext
    {
        DbSet<Log> Logs { get; set; }
    }
}
