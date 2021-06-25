using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0076.A001;

using R5T.D0077.Configuration;


namespace R5T.D0077.A001
{
    public static class IServiceCollectionExtensions
    {
        public static ServicesAggregation01 AddDotnetExecutableServices(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction)
        {
            var commandLineOperatorServices = services.AddCommandLineOperatorServices();

            var dotnetExecutableFilePathProviderAction = services.AddDotnetExecutableFilePathProviderAction(
                configurationAction);

            var dotnetOperatorAction = services.AddDotnetOperatorAction(
                commandLineOperatorServices.CommandLineOperatorAction,
                dotnetExecutableFilePathProviderAction);

            return new ServicesAggregation01()
                .As<ServicesAggregation01, IServiceAggregation01Increment>(increment =>
                {
                    increment.DotnetExecutableFilePathProviderAction = dotnetExecutableFilePathProviderAction;
                    increment.DotnetOperatorAction = dotnetOperatorAction;
                })
                .FillFrom(commandLineOperatorServices);
        }
    }
}
