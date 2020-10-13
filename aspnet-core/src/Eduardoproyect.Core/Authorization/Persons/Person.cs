using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Eduardoproyect.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using Abp.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Eduardoproyect.Authorization.Persons
{
    [Table("AbpPersons")]
    public class Person : Entity
    {

        public Person()
        {
            
        }

        public string Director {get; set;}
        public string Productor { get; set; }
        public int Year { get; set; }
        public bool succefull { get; set; }
    }
}
