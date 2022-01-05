using System;

using R5T.Suebia;

using R5T.D0076;
using R5T.T0062;
using R5T.T0063;

using R5T.D0077.Default;
using R5T.D0077.Default.I001;


namespace R5T.D0077.A002
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation01 AddDotnetOperatorActions(this IServiceAction _,
            IServiceAction<ICommandLineOperator> commandLineOperatorAction,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var dotnetExecutableFilePathProviderAction = _.AddDotnetExecutableFilePathProviderAction(
                secretsDirectoryFilePathProviderAction);

            var dotnetOperatorAction = _.AddDotnetOperatorAction(
                commandLineOperatorAction,
                dotnetExecutableFilePathProviderAction);

            var output = new ServiceActionAggregation01
            {
                DotnetExecutableFilePathProviderAction = dotnetExecutableFilePathProviderAction,
                DotnetOperatorAction = dotnetOperatorAction,
            };

            return output;
        }
    }
}