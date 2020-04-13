using System.Collections.Generic;
using System.Linq;
using Algorithm.Composition.Interfaces;

namespace Algorithm.Composition.FilterStrategies
{
    public class LowPassFilter : IMeasurementFilter
    {
        public IEnumerable<Measurement> Filter(IEnumerable<Measurement> measurements)
        {
            return measurements.Where(m => m.X < 100 & m.Y < 100);
        }
    }
}