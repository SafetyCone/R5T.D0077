using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Magyar.Extensions;

using R5T.D0076.A001;

using R5T.D0077.Configuration;
using R5T.D0077.Default;


namespace R5T.D0077.A001
{
    public static class IServiceCollectionExtensions
    {
        public static ServicesAggregation01 AddDotnetExecutableServices(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction)
        {
            var commandLineOperatorServices = services.AddCommandLineOperatorServices();

            var dotnetExecutableFilePathProviderAction = services.AddDotnetExecutableFilePathProviderAction_Old(
                configurationAction);

            var dotnetOperatorAction = services.AddDotnetOperatorAction_Old(
                commandLineOperatorServices.CommandLineOperatorAction,
                dotnetExecutableFilePathProviderAction);

            return new ServicesAggregation01()
                .ModifyAs<ServicesAggregation01, IServiceAggregation01Increment>(increment =>
                {
                    increment.DotnetExecutableFilePathProviderAction = dotnetExecutableFilePathProviderAction;
                    increment.DotnetOperatorAction = dotnetOperatorAction;
                })
                .FillFrom(commandLineOperatorServices);
        }
    }
}
