using System.Collections.Generic;

namespace Algorithm.Composition.Interfaces
{
    public interface IMeasurementFilter
    {
        IEnumerable<Measurement> Filter(IEnumerable<Measurement> measurements);
    }
}