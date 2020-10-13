using System.Collections.Generic;

namespace Eduardoproyect.Movies.Dto
{
    public class GetMovieForEditOutput
    {
        public MovieEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}