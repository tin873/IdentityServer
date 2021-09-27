using IdentityServer.Shared.Configuration.Configuration.Identity;
using IdentityServer.STS.Identity.Configuration.Interfaces;

namespace IdentityServer.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}