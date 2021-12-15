using System;

using Microsoft.Extensions.Configuration;

using R5T.Magyar;

using R5T.D0076.A001;
using R5T.T0062;
using R5T.T0063;

using R5T.D0077.Configuration;
using R5T.D0077.Default;


namespace R5T.D0077.A001
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation01 AddDotnetExecutableServices(this IServiceAction _,
            IServiceAction<IConfiguration> configurationAction)
        {
            var commandLineOperatorServices = _.AddCommandLineOperatorServiceActions();

            var dotnetExecutableFilePathProviderAction = _.AddDotnetExecutableFilePathProviderAction(
                configurationAction);

            var dotnetOperatorAction = _.AddDotnetOperatorAction(
                commandLineOperatorServices.CommandLineOperatorAction,
                dotnetExecutableFilePathProviderAction);

            var output = new ServiceActionAggregation01()
                .As<ServiceActionAggregation01, IServiceActionAggregation01Increment>(increment =>
                {
                    increment.DotnetExecutableFilePathProviderAction = dotnetExecutableFilePathProviderAction;
                    increment.DotnetOperatorAction = dotnetOperatorAction;
                })
                .FillFrom(commandLineOperatorServices);

            return output;
        }
    }
}
