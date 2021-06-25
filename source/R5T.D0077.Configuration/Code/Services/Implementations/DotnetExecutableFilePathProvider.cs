using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using R5T.T0022;


namespace R5T.D0077.Configuration
{
    public class DotnetExecutableFilePathProvider : IDotnetExecutableFilePathProvider
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
