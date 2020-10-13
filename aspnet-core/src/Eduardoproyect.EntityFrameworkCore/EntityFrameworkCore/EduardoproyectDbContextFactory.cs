using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Eduardoproyect.Configuration;
using Eduardoproyect.Web;

namespace Eduardoproyect.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EduardoproyectDbContextFactory : IDesignTimeDbContextFactory<EduardoproyectDbContext>
    {
        public EduardoproyectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EduardoproyectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EduardoproyectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EduardoproyectConsts.ConnectionStringName));

            return new EduardoproyectDbContext(builder.Options);
        }
    }
}
