using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Eduardoproyect.Controllers
{
    public abstract class EduardoproyectControllerBase: AbpController
    {
        protected EduardoproyectControllerBase()
        {
            LocalizationSourceName = EduardoproyectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
