using Api.Core.Domain;
using Api.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Extensions
{
    public static class IdentityService
    {
        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<ApiContext>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}
