using Api.Data;
using Api.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Extensions
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, string connStr)
        {
            #region Other Service Dependency
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMemberService, MemberService>();
            #endregion


            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApiContext>(options => options.UseSqlServer(connStr));
            return services;
        }
    }
}
