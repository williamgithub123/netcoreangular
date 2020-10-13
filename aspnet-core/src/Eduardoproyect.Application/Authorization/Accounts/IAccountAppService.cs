using System.Threading.Tasks;
using Abp.Application.Services;
using Eduardoproyect.Authorization.Accounts.Dto;

namespace Eduardoproyect.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
