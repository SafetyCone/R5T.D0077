using System;

using R5T.T0063;


namespace R5T.D0077.A002
{
    public interface IServiceActionAggregation01
    {
        IServiceAction<IDotnetExecutableFilePathProvider> DotnetExecutableFilePathProviderAction { get; set; }
        IServiceAction<IDotnetOperator> DotnetOperatorAction { get; set; }
    }
}
