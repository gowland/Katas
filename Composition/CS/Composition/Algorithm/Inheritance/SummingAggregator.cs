using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Inheritance
{
    public class SummingAggregator : PointsAggregator
    {
        protected override IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements)
        {
            return measurements;
        }

        protected override Measurement AggregateMeasurements(IEnumerable<Measurement> measurements)
        {
            measurements = measurements.ToArray();
            return new Measurement {X = measurements.Sum(m => m.X), Y = measurements.Sum(m => m.Y)};
        }
    }
}