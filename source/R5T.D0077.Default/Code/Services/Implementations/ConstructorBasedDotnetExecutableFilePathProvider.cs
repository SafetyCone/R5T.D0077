using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0077
{
    [ServiceImplementationMarker]
    public class ConstructorBasedDotnetExecutableFilePathProvider : IDotnetExecutableFilePathProvider, IServiceImplementation
    {
        private string DotnetExecutableFilePath { get; }


        public ConstructorBasedDotnetExecutableFilePathProvider(
            [NotServiceComponent] string dotnetExecutableFilePath)
        {
            this.DotnetExecutableFilePath = dotnetExecutableFilePath;
        }

        public Task<string> GetDotnetExecutableFilePath()
        {
            return Task.FromResult(this.DotnetExecutableFilePath);
        }
    }
}
