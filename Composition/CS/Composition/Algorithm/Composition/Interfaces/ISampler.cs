using System.Collections.Generic;

namespace Algorithm.Composition.Interfaces
{
    public interface ISampler
    {
        IEnumerable<Measurement> Sample(IEnumerable<Measurement> measurements);
    }
}