using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using Eduardoproyect.Authorization.Roles;
using Eduardoproyect.Authorization.Persons;

namespace Eduardoproyect.Persons.Dto
{
    [AutoMap(typeof(Person))]
    public class PersonDto : EntityDto<int>
    {
        public string Director { get; set; }
        public string Productor { get; set; }
        public int Year { get; set; }
        public bool succefull { get; set; }
    }
}