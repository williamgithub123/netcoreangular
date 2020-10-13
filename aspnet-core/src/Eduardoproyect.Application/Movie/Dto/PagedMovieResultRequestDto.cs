using Abp.Application.Services.Dto;

namespace Eduardoproyect.Movies.Dto
{
    public class PagedMovieResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

