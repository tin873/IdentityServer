using IdentityServer.Admin.EntityFramework.Configuration.Configuration.Identity;
using System.Collections.Generic;

namespace IdentityServer.Admin.EntityFramework.Configuration.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}
