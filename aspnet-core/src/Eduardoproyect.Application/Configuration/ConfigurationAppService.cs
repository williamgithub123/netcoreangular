using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Eduardoproyect.Configuration.Dto;

namespace Eduardoproyect.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EduardoproyectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
