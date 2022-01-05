using System;
using System.Threading.Tasks;

using R5T.D0076;
using R5T.T0064;


namespace R5T.D0077
{
    [ServiceDefinitionMarker]
    public interface IDotnetOperator : IServiceDefinition
    {
        Task Execute(string command);
        Task<CommandLineExecutionResult> ExecuteGetResult(string command);
    }
}
