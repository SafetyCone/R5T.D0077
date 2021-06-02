using System;
using System.Threading.Tasks;


namespace R5T.D0077
{
    public class ConstructorBasedDotnetExecutableFilePathProvider : IDotnetExecutableFilePathProvider
    {
        private string DotnetExecutableFilePath { get; }


        public ConstructorBasedDotnetExecutableFilePathProvider(
            string dotnetExecutableFilePath)
        {
            this.DotnetExecutableFilePath = dotnetExecutableFilePath;
        }

        public Task<string> GetDotnetExecutableFilePath()
        {
            return Task.FromResult(this.DotnetExecutableFilePath);
        }
    }
}
