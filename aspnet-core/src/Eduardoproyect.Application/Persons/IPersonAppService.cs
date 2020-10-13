using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Eduardoproyect.Roles.Dto;
using Eduardoproyect.Persons.Dto;
using Eduardoproyect.Users.Dto;

namespace Eduardoproyect.Persons
{
    public interface IPersonAppService : IAsyncCrudAppService<PersonDto>
    {
        
    }
}
