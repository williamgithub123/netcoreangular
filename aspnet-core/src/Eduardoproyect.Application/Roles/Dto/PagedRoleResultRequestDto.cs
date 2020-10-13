using Abp.Application.Services.Dto;

namespace Eduardoproyect.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

