using System.Collections.Generic;

namespace Algorithm.Composition.Interfaces
{
    public interface IAggregationStrategy
    {
        Measurement Aggregate(IEnumerable<Measurement> measurements);
    }
}