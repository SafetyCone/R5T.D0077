using System;

using R5T.Dacia;


namespace R5T.D0077.A001
{
    public interface IServiceAggregation01Increment
    {
        IServiceAction<IDotnetExecutableFilePathProvider> DotnetExecutableFilePathProviderAction { get; set; }
        IServiceAction<IDotnetOperator> DotnetOperatorAction { get; set; }
    }
}
