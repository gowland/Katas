using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Inheritance
{
    public class AveragingAggregator : PointsAggregator
    {
        protected override Measurement AggregateMeasurements(IEnumerable<Measurement> measurements)
        {
            measurements = measurements.ToArray();
            return new Measurement
                       {
                           X = (int)measurements.Average(m => m.X), 
                           Y = (int)measurements.Average(m => m.Y)
                       };
        }
    }
}