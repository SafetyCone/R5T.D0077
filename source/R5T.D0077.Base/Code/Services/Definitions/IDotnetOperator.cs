using System;
using System.Threading.Tasks;

using R5T.D0076;


namespace R5T.D0077
{
    public interface IDotnetOperator
    {
        Task Execute(string command);
        Task<CommandLineExecutionResult> ExecuteGetResult(string command);
    }
}
