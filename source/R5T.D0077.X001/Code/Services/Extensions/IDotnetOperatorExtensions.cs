using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public static Task RemoveProjectReferenceFromSolution(this IDotnetOperator dotnetOperator, string solutionFilePathToModify, string projectReferenceFilePathToRemove)
        {
            var command = CommandBuilder.New()
                .RemoveProjectFromSolution(solutionFilePathToModify, projectReferenceFilePathToRemove)
                .Build();

            return dotnetOperator.Execute(command);
        }
    }
}
