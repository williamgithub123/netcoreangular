using Abp.Authorization.Roles;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Eduardoproyect.Authorization.Users;

namespace Eduardoproyect.Authorization.Movies
{
    public class MovieStore : AbpRoleStore<Movie, User>
    {
        public MovieStore(
            IUnitOfWorkManager unitOfWorkManager,
            IRepository<Movie> roleRepository,
            IRepository<RolePermissionSetting, long> rolePermissionSettingRepository)
            : base(
                unitOfWorkManager,
                roleRepository,
                rolePermissionSettingRepository)
        {
        }
    }
}
