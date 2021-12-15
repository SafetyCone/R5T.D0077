using System;

using Microsoft.Extensions.Configuration;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0077.Configuration
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDotnetExecutableFilePathProvider> AddDotnetExecutableFilePathProviderAction(this IServiceAction _,
            IServiceAction<IConfiguration> configurationAction)
        {
            var serviceAction = _.New<IDotnetExecutableFilePathProvider>(services => services.AddDotnetExecutableFilePathProvider(
                configurationAction));

            return serviceAction;
        }
    }
}
