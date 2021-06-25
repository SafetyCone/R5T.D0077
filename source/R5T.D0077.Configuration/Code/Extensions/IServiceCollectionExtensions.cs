using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0077.Configuration
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDotnetExecutableFilePathProvider(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction)
        {
            services.AddSingleton<IDotnetExecutableFilePathProvider, DotnetExecutableFilePathProvider>()
                .Run(configurationAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDotnetExecutableFilePathProvider> AddDotnetExecutableFilePathProviderAction(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction)
        {
            var serviceAction = ServiceAction.New<IDotnetExecutableFilePathProvider>(() => services.AddDotnetExecutableFilePathProvider(
                configurationAction));

            return serviceAction;
        }
    }
}
