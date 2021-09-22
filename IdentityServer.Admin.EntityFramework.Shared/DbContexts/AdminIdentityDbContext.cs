using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityServer.Admin.EntityFramework.Shared.Constants;
using IdentityServer.Admin.EntityFramework.Shared.Entities.Identity;

namespace IdentityServer.Admin.EntityFramework.Shared.DbContexts
{
    public class AdminIdentityDbContext : IdentityDbContext<User, Role, string, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public AdminIdentityDbContext(DbContextOptions<AdminIdentityDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ConfigureIdentityContext(builder);
        }

        private void ConfigureIdentityContext(ModelBuilder builder)
        {
            builder.Entity<Role>().ToTable(TableConsts.IdentityRoles);
            builder.Entity<RoleClaim>().ToTable(TableConsts.IdentityRoleClaims);
            builder.Entity<UserRole>().ToTable(TableConsts.IdentityUserRoles);

            builder.Entity<User>().ToTable(TableConsts.IdentityUsers);
            builder.Entity<UserLogin>().ToTable(TableConsts.IdentityUserLogins);
            builder.Entity<UserClaim>().ToTable(TableConsts.IdentityUserClaims);
            builder.Entity<UserToken>().ToTable(TableConsts.IdentityUserTokens);
        }
    }
}
