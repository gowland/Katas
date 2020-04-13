using System.Collections.Generic;
using System.Linq;
using Algorithm.Composition.Interfaces;

namespace Algorithm.Composition.AggregationStrategies
{
    public class AveragingStrategy : IAggregationStrategy
    {
        public Measurement Aggregate(IEnumerable<Measurement> measurements)
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