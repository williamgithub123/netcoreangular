using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Eduardoproyect.Movies.Dto;
using Eduardoproyect.Roles.Dto;

namespace Eduardoproyect.Movies
{
    public interface IMovieAppService : IAsyncCrudAppService<MovieDto, int, PagedRoleResultRequestDto, CreateMovieDto, MovieDto>
    {
        //Task<ListResultDto<PermissionDto>> GetAllPermissions();

        //Task<GetMovieForEditOutput> GetMovieForEdit(EntityDto input);

        Task<ListResultDto<MovieListDto>> GetMoviesAsync(GetMoviesInput input);
    }
}
