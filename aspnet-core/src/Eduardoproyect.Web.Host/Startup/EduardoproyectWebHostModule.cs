using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Eduardoproyect.Configuration;

namespace Eduardoproyect.Web.Host.Startup
{
    [DependsOn(
       typeof(EduardoproyectWebCoreModule))]
    public class EduardoproyectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EduardoproyectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EduardoproyectWebHostModule).GetAssembly());
        }
    }
}
