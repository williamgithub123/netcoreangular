using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Abp.Localization;
using Abp.Runtime.Session;
using Abp.UI;
using Eduardoproyect.Authorization;
using Eduardoproyect.Authorization.Accounts;
using Eduardoproyect.Authorization.Roles;
using Eduardoproyect.Authorization.Persons;
using Eduardoproyect.Authorization.Peliculas;
using Eduardoproyect.Authorization.Users;
using Eduardoproyect.Roles.Dto;
using Eduardoproyect.Persons.Dto;
using Eduardoproyect.Peliculas.Dto;
using Eduardoproyect.Users.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Abp.AutoMapper;

namespace Eduardoproyect.Peliculas
{

    public class PeliculaAppService : AsyncCrudAppService<Pelicula, PeliculaDto>, IPeliculaAppService
    {
       
        public PeliculaAppService(IRepository<Pelicula> repository)
            : base(repository)
        {

        }

    } 
}

