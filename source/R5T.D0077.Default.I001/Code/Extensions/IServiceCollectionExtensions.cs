using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Suebia;

using R5T.T0063;


namespace R5T.D0077.Default.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDotnetExecutableFilePathProvider(this IServiceCollection services,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            services
                .Run(secretsDirectoryFilePathProviderAction)
                .AddSingleton<IDotnetExecutableFilePathProvider, DotnetExecutableFilePathProvider>();

            return services;
        }
    }
}