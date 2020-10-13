using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using Eduardoproyect.Authorization.Roles;
using Eduardoproyect.Authorization.Persons;
using Eduardoproyect.Authorization.Peliculas;

namespace Eduardoproyect.Peliculas.Dto
{
    [AutoMap(typeof(Pelicula))]
    public class PeliculaDto : EntityDto<int>
    {
        public string director { get; set; }
        public string productor { get; set; }
        public int year { get; set; }
        public bool successfull { get; set; }
    }
}