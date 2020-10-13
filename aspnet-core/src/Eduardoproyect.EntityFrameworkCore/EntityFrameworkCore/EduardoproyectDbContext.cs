using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Eduardoproyect.Authorization.Roles;
using Eduardoproyect.Authorization.Movies;
using Eduardoproyect.Authorization.Persons;
using Eduardoproyect.Authorization.Peliculas;
using Eduardoproyect.Authorization.Users;
using Eduardoproyect.MultiTenancy;

namespace Eduardoproyect.EntityFrameworkCore
{
    public class EduardoproyectDbContext : AbpZeroDbContext<Tenant, Role, User, EduardoproyectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EduardoproyectDbContext(DbContextOptions<EduardoproyectDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> persons { get; set; }

        public DbSet<Pelicula> peliculas { get; set; }
    }
}
