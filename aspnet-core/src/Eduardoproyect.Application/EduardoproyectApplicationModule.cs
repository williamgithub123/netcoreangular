using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Eduardoproyect.Authorization;

namespace Eduardoproyect
{
    [DependsOn(
        typeof(EduardoproyectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EduardoproyectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EduardoproyectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EduardoproyectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
