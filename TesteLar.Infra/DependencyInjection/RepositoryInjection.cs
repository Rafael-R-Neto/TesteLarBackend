using Microsoft.Extensions.DependencyInjection;
using TesteLar.Domain.Interfaces;
using TesteLar.Infra.Repository;

namespace TesteLar.Infra.DependencyInjection;
public static class RepositoryInjection
{
    /// <summary>
    /// Configures the service injection for the application.
    /// </summary>
    /// <param name="services">The service collection to configure.</param>
    /// <returns>The configured service collection.</returns>
    /// <remarks>This method is used to set up dependency injection for the application.</remarks>

    public static IServiceCollection AddRepositoryInjection(this IServiceCollection services)
    {
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IPhoneTypeRepository, PhoneTypeRepository>();
        //services.AddScoped<IPhoneRepository, PhoneRepository>();
        return services;
    }
}
