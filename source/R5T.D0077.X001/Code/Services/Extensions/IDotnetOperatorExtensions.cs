using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.T0029;
using R5T.T0029.Dotnet.Add;
using R5T.T0029.Dotnet.X001; /// <see cref="R5T.T0029.Dotnet.X001.Documentation"/>


namespace R5T.D0077.X001
{
    public static class IDotnetOperatorExtensions
    {
        public static Task AddProjectReferenceToProject(this IDotnetOperator dotnetOperator, string projectToModifyFilePath, string projectReferenceFilePathToAdd)
        {
            var command = CommandBuilder.New()
                .Add(projectToModifyFilePath, ListHelper.From(projectReferenceFilePathToAdd))
                .Build();

            return dotnetOperator.Execute(command);
        }

        public static Task AddProjectReferenceToSolution(this IDotnetOperator dotnetOperator, string solutionFilePathToModify, string projectReferenceFilePathToAdd)
        {
            var command = CommandBuilder.New()
                .AddProjectToSolution(solutionFilePathToModify, projectReferenceFilePathToAdd)
                .Build();

            return dotnetOperator.Execute(command);
        }

        public static Task AddProjectReferenceToSolution(this IDotnetOperator dotnetOperator,
            string solutionFilePathToModify,
            string projectReferenceFilePathToAdd,
            string solutionFolder)
        {
            var command = CommandBuilder.New()
                .AddProjectToSolution(
                    solutionFilePathToModify,
                    projectReferenceFilePathToAdd,
                    solutionFolder)
                .Build();

            return dotnetOperator.Execute(command);
        }

        public static Task RemoveProjectReferenceFromProjectIdempotent(this IDotnetOperator dotnetOperator,
            string projectFilePathToModify,
            string projectReferenceFilePathToRemove)
        {
            var command = CommandBuilder.New()
                .RemoveProjectFromProject(
                    projectFilePathToModify,
                    projectReferenceFilePathToRemove)
                .Build();

            return dotnetOperator.Execute(command);
        }

        public static Task RemoveProjectReferenceFromSolution(this IDotnetOperator dotnetOperator, string solutionFilePathToModify, string projectReferenceFilePathToRemove)
        {
            var command = CommandBuilder.New()
                .RemoveProjectFromSolution(solutionFilePathToModify, projectReferenceFilePathToRemove)
                .Build();

            return dotnetOperator.Execute(command);
        }

        public static async Task<string[]> ListSolutionProjectReferenceRelativePaths(this IDotnetOperator dotnetOperator,
            string solutionFilePath)
        {
            var command = CommandBuilder.New()
                .ListSolutionProjectReferenceRelativePaths(solutionFilePath)
                .Build();

            var result = await dotnetOperator.ExecuteGetResult(command);

            var output = result.OutputLines
                .Skip(2) // Skip "Project(s)" and "----------"
                .ExceptLast() // Skip the final empty line.
                .ToArray();
                ;

            return output;
        }

        public static async Task<string[]> ListProjectProjectReferenceRelativePaths(this IDotnetOperator dotnetOperator,
            string projectFilePath)
        {
            var command = CommandBuilder.New()
                .ListProjectProjectReferenceRelativePaths(projectFilePath)
                .Build();

            var result = await dotnetOperator.ExecuteGetResult(command);

            var output = result.OutputLines
                .Skip(2) // Skip "Project reference(s)" and "--------------------"
                .ExceptLast() // Skip the final empty line.
                .ToArray();
            ;

            return output;
        }
    }
}
