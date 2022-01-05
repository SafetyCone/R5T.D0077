using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0077
{
    [ServiceDefinitionMarker]
    public interface IDotnetExecutableFilePathProvider : IServiceDefinition
    {
        Task<string> GetDotnetExecutableFilePath();
    }
}
