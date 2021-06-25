using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using R5T.T0027.Configuration.SecretsFilePaths;


namespace R5T.D0077.Configuration
{
    public static class IConfigurationBuilderExtensions
    {
        public static Task<IConfigurationBuilder> AddDotnetConfigurationSecretsFilePath(this IConfigurationBuilder configurationBuilder, IServiceProvider startupServicesProvider)
        {
            return configurationBuilder.AddSecretsFilePath(FileName.Instance.DotnetSecretsConfiguration(), startupServicesProvider);
        }
    }
}
