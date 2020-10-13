using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Eduardoproyect.Authorization;
using Eduardoproyect.Authorization.Movies;
using Eduardoproyect.Authorization.Roles;
using Eduardoproyect.Authorization.Users;
using Eduardoproyect.Movies.Dto;
using Eduardoproyect.Roles.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Eduardoproyect.Movies
{
    //[AbpAuthorize(PermissionNames.Pages_Roles)]
    public class MovieAppService : AsyncCrudAppService<Role, MovieDto, int, PagedRoleResultRequestDto, CreateMovieDto, MovieDto>, IMovieAppService
    {
        //private readonly MovieManager _movieManager;
        private readonly UserManager _userManager;

        //, MovieManager movieManager, 

        public MovieAppService(IRepository<Role> repository, UserManager userManager)
            : base(repository)
        {
            //_movieManager = movieManager;
            _userManager = userManager;
        }

        //------------------------------------------------------------------------------------------

        public async Task<ListResultDto<MovieListDto>> GetMoviesAsync(GetMoviesInput input)
        {
            var roles = 0;

            return new ListResultDto<MovieListDto>(ObjectMapper.Map<List<MovieListDto>>(roles));
        }

        //-------------------------------------------------------------------------------------------------



        //-------------------------------------------------------------------------------------------------

        //public override async Task<MovieDto> CreateAsync(CreateMovieDto input)
        //{
        //    CheckCreatePermission();

        //    var role = ObjectMapper.Map<Movie>(input);
        //    role.SetNormalizedName();

        //    CheckErrors(await _movieManager.CreateAsync(role));

        //    var grantedPermissions = PermissionManager
        //        .GetAllPermissions()
        //        .Where(p => input.GrantedPermissions.Contains(p.Name))
        //        .ToList();

        //    await _movieManager.SetGrantedPermissionsAsync(role, grantedPermissions);

        //    return MapToEntityDto(role);
        //}

        ////------------------------------------------------------------------------------------------

        //protected virtual void CheckErrors(IdentityResult identityResult)
        //{
        //    identityResult.CheckErrors(LocalizationManager);
        //}

        ////------------------------------------------------------------------------------------------

        //public async Task<ListResultDto<MovieListDto>> GetMoviesAsync(GetMoviesInput input)
        //{
        //    var roles = await _movieManager
        //        .Roles
        //        .WhereIf(
        //            !input.Permission.IsNullOrWhiteSpace(),
        //            r => r.Permissions.Any(rp => rp.Name == input.Permission && rp.IsGranted)
        //        )
        //        .ToListAsync();

        //    return new ListResultDto<MovieListDto>(ObjectMapper.Map<List<MovieListDto>>(roles));
        //}

        ////-----------------------------------------------------------------------------------------------------

        //public override async Task<MovieDto> UpdateAsync(MovieDto input)
        //{
        //    CheckUpdatePermission();

        //    var role = await _movieManager.GetRoleByIdAsync(input.Id);

        //    ObjectMapper.Map(input, role);

        //    CheckErrors(await _movieManager.UpdateAsync(role));

        //    var grantedPermissions = PermissionManager
        //        .GetAllPermissions()
        //        .Where(p => input.GrantedPermissions.Contains(p.Name))
        //        .ToList();

        //    await _movieManager.SetGrantedPermissionsAsync(role, grantedPermissions);

        //    return MapToEntityDto(role);
        //}

        ////----------------------------------------------------------------------------------------------

        //public override async Task DeleteAsync(EntityDto<int> input)
        //{
        //    CheckDeletePermission();

        //    var role = await _movieManager.FindByIdAsync(input.Id.ToString());
        //    var users = await _userManager.GetUsersInRoleAsync(role.NormalizedName);

        //    foreach (var user in users)
        //    {
        //        CheckErrors(await _userManager.RemoveFromRoleAsync(user, role.NormalizedName));
        //    }

        //    CheckErrors(await _movieManager.DeleteAsync(role));
        //}

        ////---------------------------------------------------------------------------------------------------------

        //protected override IQueryable<Movie> CreateFilteredQuery(PagedMovieResultRequestDto input)
        //{
        //    return Repository.GetAllIncluding(x => x.Permissions)
        //        .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Keyword)
        //        || x.DisplayName.Contains(input.Keyword));
        //}

        ////---------------------------------------------------------------------------------------------------------------

        //protected override async Task<Movie> GetEntityByIdAsync(int id)
        //{
        //    return await Repository.GetAllIncluding(x => x.Permissions).FirstOrDefaultAsync(x => x.Id == id);
        //}

        ////--------------------------------------------------------------------------------------------------------------

        //protected override IQueryable<Movie> ApplySorting(IQueryable<Movie> query, PagedMovieResultRequestDto input)
        //{
        //    return query.OrderBy(r => r.DisplayName);
        //}

        //--------------------------------------------------------------------------------------------------------------




    }
}

