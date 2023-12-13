using TEAChallenge.Data.Repositories;
using TEAChallenge.Services;

namespace TEAChallenge.Host.ServiceExtensions;

public static partial class ServiceExtensions
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<IStudentRepository, StudentRepository>();

        return services;
    }
}