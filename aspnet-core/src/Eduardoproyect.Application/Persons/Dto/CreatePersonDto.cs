using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Eduardoproyect.Authorization.Roles;

namespace Eduardoproyect.Persons.Dto
{
    public class CreatePersonDto
    {
        public string Director { get; set; }
        public string Productor { get; set; }
        public int Year { get; set; }
        public bool succefull { get; set; }

        public List<string> GrantedPermissions { get; set; }
    }
}
