using System;


namespace R5T.D0077.A001
{
    public static class ServiceAggregation01IncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregation01Increment other)
            where T : IServiceAggregation01Increment
        {
            aggregation.DotnetExecutableFilePathProviderAction = other.DotnetExecutableFilePathProviderAction;
            aggregation.DotnetOperatorAction = other.DotnetOperatorAction;

            return aggregation;
        }
    }
}
