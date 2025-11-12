using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Template.DataAccess.Configuration.Options;

namespace Template.DataAccess.Configuration;

public static class DataAccessDependencyInjection
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<ConnectionStringsOptions>(configuration.GetSection("ConnectionStrings"));
        
        return services;
    }
}