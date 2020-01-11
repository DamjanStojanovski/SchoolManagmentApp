using DataAccess;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Microsoft.EntityFrameworkCore;
namespace Services.Helpers
{
    public class DIModule
    {

        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SchoolDBCOntext>(x => x.UseSqlServer(connectionString));

            //register repositories
            services.AddTransient<ISchoolRepository, SchoolRepository>();
            services.AddTransient<IMuncipalityRepository, MuncipalityRepository>();
            return services;
        }

    }
}
