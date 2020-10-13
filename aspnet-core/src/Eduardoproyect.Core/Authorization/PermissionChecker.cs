using Abp.Authorization;
using Eduardoproyect.Authorization.Roles;
using Eduardoproyect.Authorization.Users;

namespace Eduardoproyect.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
