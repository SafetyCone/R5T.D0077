using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0076;


namespace R5T.D0077.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DotnetOperator"/> implementation of <see cref="IDotnetOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDotnetOperator_Old(this IServiceCollection services,
            IServiceAction<ICommandLineOperator> commandLineOperatorAction,
            IServiceAction<IDotnetExecutableFilePathProvider> dotnetExecutableFilePathProviderAction)
        {
            services.AddSingleton<IDotnetOperator, DotnetOperator>()
                .Run(commandLineOperatorAction)
                .Run(dotnetExecutableFilePathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DotnetOperator"/> implementation of <see cref="IDotnetOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDotnetOperator> AddDotnetOperatorAction_Old(this IServiceCollection services,
            IServiceAction<ICommandLineOperator> commandLineOperatorAction,
            IServiceAction<IDotnetExecutableFilePathProvider> dotnetExecutableFilePathProviderAction)
        {
            var serviceAction = ServiceAction.New<IDotnetOperator>(() => services.AddDotnetOperator_Old(
                commandLineOperatorAction,
                dotnetExecutableFilePathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedDotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDotnetExecutableFilePathProvider> AddConstructorBasedDotnetExecutableFilePathProviderAction_Old(this IServiceCollection services,
            string dotnetExecutableFilePath)
        {
            var serviceAction = ServiceAction.New<IDotnetExecutableFilePathProvider>(() => services.AddConstructorBasedDotnetExecutableFilePathProvider(
                dotnetExecutableFilePath));

            return serviceAction;
        }
    }
}
