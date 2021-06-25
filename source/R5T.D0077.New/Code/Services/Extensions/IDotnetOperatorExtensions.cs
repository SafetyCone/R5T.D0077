using System;
using System.Threading.Tasks;

using R5T.T0029;
using R5T.T0029.Dotnet.New;
using R5T.T0029.Dotnet.T001;


namespace R5T.D0077.New
{
    public static class IDotnetOperatorExtensions
    {
        public static Task New(this IDotnetOperator dotnetOperator, string templateName, string name, string output)
        {
            var command = CommandBuilder.New()
                .New(templateName, name, output)
                .Build();

            return dotnetOperator.Execute(command);
        }

        public static Task NewConsole(this IDotnetOperator dotnetOperator, string projectName, string projectDirectoryPath)
        {
            return dotnetOperator.New(DotnetNewTemplate.Instance.Console(), projectName, projectDirectoryPath);
        }

        public static Task NewLibrary(this IDotnetOperator dotnetOperator, string projectName, string projectDirectoryPath)
        {
            return dotnetOperator.New(DotnetNewTemplate.Instance.ClassLib(), projectName, projectDirectoryPath);
        }

        public static Task NewSolution(this IDotnetOperator dotnetOperator, string solutionName, string solutionDirectoryPath)
        {
            return dotnetOperator.New(DotnetNewTemplate.Instance.Sln(), solutionName, solutionDirectoryPath);
        }
    }
}
