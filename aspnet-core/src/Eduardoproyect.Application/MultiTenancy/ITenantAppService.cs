using Abp.Application.Services;
using Eduardoproyect.MultiTenancy.Dto;

namespace Eduardoproyect.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

