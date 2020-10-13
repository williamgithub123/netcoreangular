using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Eduardoproyect.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using Abp.Authorization.Users;

namespace Eduardoproyect.Authorization.Movies
{
    public class Movie : AbpRole<User>
    {

        public Movie()
        {
        }
       

        public string Director {get; set;}
        public string Productor { get; set; }
        public int Year { get; set; }
        public bool succefull { get; set; }
    }
}
