﻿using System;
using System.Threading.Tasks;

using R5T.D0076;
using R5T.T0064;


namespace R5T.D0077
{
    [ServiceImplementationMarker]
    public class DotnetOperator : IDotnetOperator, IServiceImplementation
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

        public async Task<CommandLineExecutionResult> ExecuteGetResult(string command)
        {
            var dotnetExecutableFilePath = await this.DotnetExecutableFilePathProvider.GetDotnetExecutableFilePath();

            var output = await this.CommandLineOperator.RunGetResult(dotnetExecutableFilePath, command);
            return output;
        }
    }
}
