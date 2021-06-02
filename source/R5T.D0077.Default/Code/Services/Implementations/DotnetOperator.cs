using System;
using System.Threading.Tasks;

using R5T.D0076;


namespace R5T.D0077
{
    public class DotnetOperator : IDotnetOperator
    {
        private ICommandLineOperator CommandLineOperator { get; }
        private IDotnetExecutableFilePathProvider DotnetExecutableFilePathProvider { get; }


        public DotnetOperator(
            ICommandLineOperator commandLineOperator,
            IDotnetExecutableFilePathProvider dotnetExecutableFilePathProvider)
        {
            this.CommandLineOperator = commandLineOperator;
            this.DotnetExecutableFilePathProvider = dotnetExecutableFilePathProvider;
        }

        public async Task Execute(string command)
        {
            var dotnetExecutableFilePath = await this.DotnetExecutableFilePathProvider.GetDotnetExecutableFilePath();

            await this.CommandLineOperator.Run(dotnetExecutableFilePath, command);
        }
    }
}
