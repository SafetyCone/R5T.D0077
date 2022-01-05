using System;
using System.Threading.Tasks;

using Newtonsoft.Json;

using R5T.Suebia;

using R5T.T0064;


namespace R5T.D0077.Default.I001
{
    [ServiceImplementationMarker]
    public class DotnetExecutableFilePathProvider : IDotnetExecutableFilePathProvider, IServiceImplementation
    {
        private ISecretsDirectoryFilePathProvider SecretsDirectoryFilePathProvider { get; }


        public DotnetExecutableFilePathProvider(
            ISecretsDirectoryFilePathProvider secretsDirectoryFilePathProvider)
        {
            this.SecretsDirectoryFilePathProvider = secretsDirectoryFilePathProvider;
        }

        public async Task<string> GetDotnetExecutableFilePath()
        {
            var configurationDotnetJsonFilePath = await this.SecretsDirectoryFilePathProvider.GetSecretsFilePath(
                Instances.FileName.ConfigurationDotnetJson());

            var dotnetConfiguration = JsonFileHelper.LoadFromFile<DotnetConfiguration>(configurationDotnetJsonFilePath);

            return dotnetConfiguration.DotnetExecutableFilePath;
        }
    }
}