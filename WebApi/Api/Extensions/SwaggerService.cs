using Api.Configure;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Extensions
{
    public static class SwaggerService
    {
        public static IServiceCollection AddSwaggerUIGen(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            services.ConfigureOptions<ConfigureSwaggerOptions>();
            return services;
        }
    }
}
