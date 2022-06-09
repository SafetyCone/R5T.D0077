using System;

using R5T.Suebia;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0077.Default.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDotnetExecutableFilePathProvider> AddDotnetExecutableFilePathProviderAction(this IServiceAction _,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var serviceAction = _.New<IDotnetExecutableFilePathProvider>(services => services.AddDotnetExecutableFilePathProvider(
                secretsDirectoryFilePathProviderAction));

            return serviceAction;
        }
    }
}
