using System;

using R5T.T0063;


namespace R5T.D0077.A001
{
    public interface IServiceActionAggregation01Increment
    {
        IServiceAction<IDotnetExecutableFilePathProvider> DotnetExecutableFilePathProviderAction { get; set; }
        IServiceAction<IDotnetOperator> DotnetOperatorAction { get; set; }
    }
}
