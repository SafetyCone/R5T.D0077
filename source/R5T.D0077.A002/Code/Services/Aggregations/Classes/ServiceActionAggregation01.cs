using System;

using R5T.T0063;


namespace R5T.D0077.A002
{
    public class ServiceActionAggregation01 : IServiceActionAggregation01
    {
        public IServiceAction<IDotnetExecutableFilePathProvider> DotnetExecutableFilePathProviderAction { get; set; }
        public IServiceAction<IDotnetOperator> DotnetOperatorAction { get; set; }
    }
}
