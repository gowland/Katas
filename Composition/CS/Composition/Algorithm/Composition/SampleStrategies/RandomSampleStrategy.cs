using System;
using System.Collections.Generic;
using System.Linq;
using Algorithm.Composition.Interfaces;

namespace Algorithm.Composition.SampleStrategies
{
    class RandomSampleStrategy : ISampler
    {
        private readonly double _frequency;
        private readonly Random _random = new Random();

        public RandomSampleStrategy(double frequency)
        {
            _frequency = frequency;
        }

        public IEnumerable<Measurement> Sample(IEnumerable<Measurement> measurements)
        {
            return measurements.Where(m => _random.NextDouble() < _frequency);
        }
    }
}