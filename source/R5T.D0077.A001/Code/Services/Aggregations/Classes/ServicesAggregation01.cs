using System;

using R5T.Dacia;


namespace R5T.D0077.A001
{
    public class ServicesAggregation01 : D0076.A001.ServicesAggregation01, IServiceAggregation01
    {
        public IServiceAction<IDotnetExecutableFilePathProvider> DotnetExecutableFilePathProviderAction { get; set; }
        public IServiceAction<IDotnetOperator> DotnetOperatorAction { get; set; }
    }
}
