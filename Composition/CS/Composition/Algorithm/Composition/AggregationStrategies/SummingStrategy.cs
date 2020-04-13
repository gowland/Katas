using System.Collections.Generic;
using System.Linq;
using Algorithm.Composition.Interfaces;

namespace Algorithm.Composition.AggregationStrategies
{
    public class SummingStrategy : IAggregationStrategy
    {
        public Measurement Aggregate(IEnumerable<Measurement> measurements)
        {
            measurements = measurements.ToArray();
            return new Measurement { X = measurements.Sum(m => m.X), Y = measurements.Sum(m => m.Y) };
        }
    }
}