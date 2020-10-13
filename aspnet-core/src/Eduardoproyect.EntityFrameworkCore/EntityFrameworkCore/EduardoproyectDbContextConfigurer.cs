using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Eduardoproyect.EntityFrameworkCore
{
    public static class EduardoproyectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EduardoproyectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EduardoproyectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
