using Microsoft.Extensions.DependencyInjection;

namespace ProjectEuler.Problem1
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection SetupForProblem1(this IServiceCollection services)
        {
            services.AddSingleton<ICalculator, Calculator>();

            return services;
        }
    }
}
