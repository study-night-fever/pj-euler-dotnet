using Microsoft.Extensions.DependencyInjection;

namespace ProjectEuler.Problem2
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection SetupForProblem2(this IServiceCollection services)
        {
            services.AddSingleton<ICalculator, Calculator>();

            return services;
        }
    }
}
