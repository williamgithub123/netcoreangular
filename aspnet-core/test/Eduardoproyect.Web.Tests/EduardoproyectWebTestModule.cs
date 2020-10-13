using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Eduardoproyect.EntityFrameworkCore;
using Eduardoproyect.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Eduardoproyect.Web.Tests
{
    [DependsOn(
        typeof(EduardoproyectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EduardoproyectWebTestModule : AbpModule
    {
        public EduardoproyectWebTestModule(EduardoproyectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EduardoproyectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EduardoproyectWebMvcModule).Assembly);
        }
    }
}