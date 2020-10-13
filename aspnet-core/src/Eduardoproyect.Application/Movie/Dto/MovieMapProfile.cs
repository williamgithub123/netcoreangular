using System.Linq;
using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Eduardoproyect.Authorization.Movies;

namespace Eduardoproyect.Movies.Dto
{
    public class MovieMapProfile : Profile
    {
        public MovieMapProfile()
        {
            // Role and permission
            CreateMap<Permission, string>().ConvertUsing(r => r.Name);
            CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

            CreateMap<CreateMovieDto, Movie>();

            CreateMap<MovieDto, Movie>();

            CreateMap<Movie, MovieDto>().ForMember(x => x.GrantedPermissions,
                opt => opt.MapFrom(x => x.Permissions.Where(p => p.IsGranted)));

            CreateMap<Movie, MovieListDto> ();
            CreateMap<Movie, MovieEditDto>();
            CreateMap<Permission, FlatPermissionDto>();
        }
    }
}
