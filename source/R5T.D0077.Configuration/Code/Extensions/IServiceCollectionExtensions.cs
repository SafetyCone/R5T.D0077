﻿using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0077.Configuration
{
    public static partial class IServiceCollectionExtensions
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
    }
}
