using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using R5T.T0022;
using R5T.T0064;


namespace R5T.D0077.Configuration
{
    [ServiceImplementationMarker]
    public class DotnetExecutableFilePathProvider : IDotnetExecutableFilePathProvider, IServiceImplementation
    {
        private IConfiguration Configuration { get; }


        public DotnetExecutableFilePathProvider(
            IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public Task<string> GetDotnetExecutableFilePath()
        {
            var dotnetExecutableFilePath = this.Configuration[ConfigurationKeyNames.Instance.DotnetExecutableFilePath()];

            return Task.FromResult(dotnetExecutableFilePath);
        }
    }
}
