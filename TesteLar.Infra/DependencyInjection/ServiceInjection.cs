using Microsoft.Extensions.DependencyInjection;
using TesteLar.Application.ApplicationServices;
using TesteLar.Application.Interfaces;

namespace TesteLar.Infra.DependencyInjection;
public static class ServiceInjection
{
    /// <summary>
    /// Configures the service injection for the application.
    /// </summary>
    /// <param name="services">The service collection to configure.</param>
    /// <returns>The configured service collection.</returns>
    /// <remarks>This method is used to set up dependency injection for the application.</remarks>

    public static IServiceCollection AddServiceInjection(this IServiceCollection services)
    {

        services.AddScoped<IPersonApplicationService, PersonApplicationService>();
        services.AddScoped<IPhoneTypeApplicationService, PhoneTypeApplicationService>();

        return services;
    }
}
