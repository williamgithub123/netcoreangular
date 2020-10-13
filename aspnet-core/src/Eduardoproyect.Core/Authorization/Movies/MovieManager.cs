using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Organizations;
using Abp.Runtime.Caching;
using Abp.Zero.Configuration;
using Eduardoproyect.Authorization.Users;
using Eduardoproyect.Authorization.Roles;
using Microsoft.Extensions.Options;
using System;
using Abp.Configuration;

namespace Eduardoproyect.Authorization.Movies
{
    public class MovieManager : AbpRoleManager<Movie, User>
    {

        public MovieManager(
           MovieStore store,
           IEnumerable<IRoleValidator<Movie>> roleValidators,
           ILookupNormalizer keyNormalizer,
           IdentityErrorDescriber errors,
           ILogger<AbpRoleManager<Movie, User>> logger,
           IPermissionManager permissionManager,
           ICacheManager cacheManager,
           IUnitOfWorkManager unitOfWorkManager,
           IRoleManagementConfig roleManagementConfig,
           IRepository<OrganizationUnit, long> organizationUnitRepository,
           IRepository<OrganizationUnitRole, long> organizationUnitRoleRepository)
           : base(
                 store,
                 roleValidators,
                 keyNormalizer,
                 errors, logger,
                 permissionManager,
                 cacheManager,
                 unitOfWorkManager,
                 roleManagementConfig,
               organizationUnitRepository,
               organizationUnitRoleRepository)
        {
        }

    }
}
