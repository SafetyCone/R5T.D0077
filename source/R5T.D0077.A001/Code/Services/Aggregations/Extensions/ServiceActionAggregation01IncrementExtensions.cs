using System;


namespace R5T.D0077.A001
{
    public static class ServiceActionAggregation01IncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation01Increment other)
            where T : IServiceActionAggregation01Increment
        {
            aggregation.DotnetExecutableFilePathProviderAction = other.DotnetExecutableFilePathProviderAction;
            aggregation.DotnetOperatorAction = other.DotnetOperatorAction;

            return aggregation;
        }
    }
}
