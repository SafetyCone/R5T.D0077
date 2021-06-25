using System;

using R5T.D0077.A001;


namespace System
{
    public static class ServiceAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregation01 other)
            where T : IServiceAggregation01
        {
            (aggregation as R5T.D0076.A001.IServicesAggregation01).FillFrom(other);

            (aggregation as IServiceAggregation01Increment).FillFrom(other);

            return aggregation;
        }
    }
}
