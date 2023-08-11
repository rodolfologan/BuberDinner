using Microsoft.Extensions.DependencyInjection;

using BuberDinner.Aplication.Services.Authentication;

namespace BuberDinner.Aplication;


public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticaionService, AuthenticationService>();

        return services;
    }
}