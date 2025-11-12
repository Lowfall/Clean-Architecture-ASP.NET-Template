using Microsoft.Extensions.DependencyInjection;

namespace Template.Application.Configuration;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}