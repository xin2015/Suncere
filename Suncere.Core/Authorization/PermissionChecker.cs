using Abp.Authorization;
using Suncere.Authorization.Roles;
using Suncere.Authorization.Users;

namespace Suncere.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
