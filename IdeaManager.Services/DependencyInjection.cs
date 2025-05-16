using IdeaManager.Core.Interfaces;
using IdeaManager.Services;
using IdeaManager.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IdeaManager.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IIdeaService, IdeaService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}