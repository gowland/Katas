using System.Collections.Generic;
using Algorithm.Composition.Interfaces;

namespace Algorithm.Composition.FilterStrategies
{
    public class EmptyFilter : IMeasurementFilter
    {
        public IEnumerable<Measurement> Filter(IEnumerable<Measurement> measurements)
        {
            return measurements;
        }
    }
}