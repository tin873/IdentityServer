using Skoruba.AuditLogging.Events;
using IdentityServer.Admin.BusinessLogic.Identity.Dtos.Identity;

namespace IdentityServer.Admin.BusinessLogic.Identity.Events.Identity
{
    public class ClaimUsersRequestedEvent<TUsersDto> : AuditEvent
    {
        public TUsersDto Users { get; set; }

        public ClaimUsersRequestedEvent(TUsersDto users)
        {
            Users = users;
        }
    }
}