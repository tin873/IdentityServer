using IdentityServer.Admin.EntityFramework.Configuration.Configuration.Identity;
using System.Collections.Generic;

namespace IdentityServer.Admin.EntityFramework.Configuration.Configuration
{
    public class IdentityData
    {
        public List<Role> Roles { get; set; }
        public List<User> Users { get; set; }
    }
}
