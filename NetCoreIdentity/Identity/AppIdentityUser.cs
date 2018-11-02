using Microsoft.AspNetCore.Identity;

namespace NetCoreIdentity.Identity
{
    public class AppIdentityUser:IdentityUser
    {
        public int Age { get; set; }
    }
}
