using System;


namespace R5T.D0077.A002
{
    public static class IServiceActionAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation01 other)
            where T : IServiceActionAggregation01
        {
            aggregation.DotnetExecutableFilePathProviderAction = other.DotnetExecutableFilePathProviderAction;
            aggregation.DotnetOperatorAction = other.DotnetOperatorAction;

            return aggregation;
        }
    }
}
