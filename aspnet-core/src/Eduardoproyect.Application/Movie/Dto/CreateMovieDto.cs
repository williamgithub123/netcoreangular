using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Eduardoproyect.Authorization.Roles;

namespace Eduardoproyect.Movies.Dto
{
    public class CreateMovieDto
    {
        [Required]
        [StringLength(AbpRoleBase.MaxNameLength)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(AbpRoleBase.MaxDisplayNameLength)]
        public string DisplayName { get; set; }

        public string Director { get; set; }
        public string Productor { get; set; }
        public int Year { get; set; }
        public bool succefull { get; set; }

        public List<string> GrantedPermissions { get; set; }
    }
}
