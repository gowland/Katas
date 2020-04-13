using System.Collections.Generic;
using Algorithm.Composition.Interfaces;

namespace Algorithm.Composition
{
    public class PointsAggregator
    {
        public PointsAggregator(
            IAggregationStrategy aggregator,
            IMeasurementFilter filter = null,
            ISampler sampler = null)
        {
            _aggregator = aggregator;
            _filter = filter;
            _sampler = sampler;
        }

        public virtual Measurement Aggregate(IEnumerable<Measurement> measurements)
        {
            measurements = _sampler == null ? measurements : _sampler.Sample(measurements);
            measurements = _filter == null ? measurements : _filter.Filter(measurements);            
            return _aggregator.Aggregate(measurements);
        }

        private readonly ISampler _sampler;
        private readonly IMeasurementFilter _filter;
        private readonly IAggregationStrategy _aggregator;
    }        
}