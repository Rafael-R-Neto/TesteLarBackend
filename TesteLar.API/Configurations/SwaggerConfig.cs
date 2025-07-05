using Microsoft.OpenApi.Models;

namespace TesteLar.API.Configurations;
public static class SwaggerConfig
{
    public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
    {
        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new() { Title = "TesteLar Lar", Version = "v1", Contact = new OpenApiContact { Name = "Rafael", Email = "rafael.neto@coopersystem.com.br" } });
            option.SwaggerDoc("v2", new() { Title = "TesteLar Lar", Version = "v2", Contact = new OpenApiContact { Name = "Rafael", Email = "rafael.neto@coopersystem.com.br" } });
        });

        return services;
    }
}
