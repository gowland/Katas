using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Inheritance
{
    public class LowPassAveragingAggregator : AveragingAggregator
    {
        protected override IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements)
        {
            return measurements.Where(m => m.X < 100 && m.Y < 100);
        }
    }
}