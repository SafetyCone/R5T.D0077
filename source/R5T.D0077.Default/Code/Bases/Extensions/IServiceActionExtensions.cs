using System;

using R5T.D0076;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0077.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DotnetOperator"/> implementation of <see cref="IDotnetOperator"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDotnetOperator> AddDotnetOperatorAction(this IServiceAction _,
            IServiceAction<ICommandLineOperator> commandLineOperatorAction,
            IServiceAction<IDotnetExecutableFilePathProvider> dotnetExecutableFilePathProviderAction)
        {
            var serviceAction = _.New<IDotnetOperator>(services => services.AddDotnetOperator(
                commandLineOperatorAction,
                dotnetExecutableFilePathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedDotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDotnetExecutableFilePathProvider> AddConstructorBasedDotnetExecutableFilePathProviderAction(this IServiceAction _,
            string dotnetExecutableFilePath)
        {
            var serviceAction = _.New<IDotnetExecutableFilePathProvider>(services => services.AddConstructorBasedDotnetExecutableFilePathProvider(
                dotnetExecutableFilePath));

            return serviceAction;
        }
    }
}
