﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0076;
using R5T.T0063;


namespace R5T.D0077.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DotnetOperator"/> implementation of <see cref="IDotnetOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDotnetOperator(this IServiceCollection services,
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
        /// Adds the <see cref="ConstructorBasedDotnetExecutableFilePathProvider"/> implementation of <see cref="IDotnetExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedDotnetExecutableFilePathProvider(this IServiceCollection services,
            string dotnetExecutableFilePath)
        {
            services.AddSingleton<IDotnetExecutableFilePathProvider>(new ConstructorBasedDotnetExecutableFilePathProvider(dotnetExecutableFilePath));

            return services;
        }
    }
}
