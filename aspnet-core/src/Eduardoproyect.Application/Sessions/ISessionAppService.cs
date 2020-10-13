using System.Threading.Tasks;
using Abp.Application.Services;
using Eduardoproyect.Sessions.Dto;

namespace Eduardoproyect.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
