using System.Collections.Generic;
using System.Linq;
using Algorithm.Composition.Interfaces;

namespace Algorithm.Composition.SampleStrategies
{
    class RegularSampleStrategy : ISampler
    {
        private readonly int _numberToSkip;

        public RegularSampleStrategy(int numberToSkip)
        {
            _numberToSkip = numberToSkip;
        }

        public IEnumerable<Measurement> Sample(IEnumerable<Measurement> measurements)
        {
            measurements = measurements.ToArray();

            int skipped = 0;
            foreach (var measurement in measurements)
            {
                skipped = (skipped + 1) % _numberToSkip;
                if (skipped == 0)
                {
                    yield return measurement;
                }
            }
        }
    }
}