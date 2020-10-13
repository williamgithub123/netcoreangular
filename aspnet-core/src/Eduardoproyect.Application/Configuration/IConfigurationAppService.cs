using System.Threading.Tasks;
using Eduardoproyect.Configuration.Dto;

namespace Eduardoproyect.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
