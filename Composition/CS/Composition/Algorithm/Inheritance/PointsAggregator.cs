using System.Collections.Generic;

namespace Algorithm.Inheritance
{
    public abstract class PointsAggregator
    {
        public virtual Measurement Aggregate(IEnumerable<Measurement> measurements)
        {
            measurements = SampleMeasurements(measurements);
            measurements = FilterMeasurements(measurements);
            return AggregateMeasurements(measurements);
        }

        protected virtual IEnumerable<Measurement> SampleMeasurements(IEnumerable<Measurement> measurements)
        {
            return measurements;
        }

        protected virtual IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements)
        {
            return measurements;
        }

        protected abstract Measurement AggregateMeasurements(IEnumerable<Measurement> measurements);
    }        
}