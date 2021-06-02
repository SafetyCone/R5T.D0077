using System;
using System.Threading.Tasks;

using R5T.T0029;
using R5T.T0029.Dotnet.New;


namespace R5T.D0077.New
{
    public static class IDotnetOperatorExtensions
    {
        public static Task NewSolution(this IDotnetOperator dotnetOperator, string solutionName, string solutionDirectoryPath)
        {
            var command = CommandBuilder.New()
                .New(DotnetNewTemplate.Instance.Sln(), solutionName, solutionDirectoryPath)
                .Build();

            return dotnetOperator.Execute(command);
        }
    }
}
