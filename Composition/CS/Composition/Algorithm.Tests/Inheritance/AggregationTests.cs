using Algorithm.Inheritance;
using Xunit;

namespace Algorithm.Tests.Inheritance
{
    public class AggregationTests
    {
        [Fact]
        public void SummingAggregation_Produces_Sum()
        {
            var aggregator = new SummingAggregator();

            var result = aggregator.Aggregate(_measurements);

            Assert.Equal(107, result.X);
            Assert.Equal(30, result.Y);
        }

        [Fact]
        public void AveragingAggregator_Produces_Average()
        {
            var aggregator = new AveragingAggregator();

            var result = aggregator.Aggregate(_measurements);

            Assert.Equal(35, result.X);
            Assert.Equal(10, result.Y);
        }

        [Fact]
        public void LowPassAveragingAggregator_Applies_Filter()
        {
            var aggregator = new LowPassAveragingAggregator();

            var result = aggregator.Aggregate(_measurements);

            Assert.Equal(3, result.X);
            Assert.Equal(12, result.Y);            
        }

        /// Uncomment this test and make it pass reusing as much code as 
        /// possible from other classes that are available in the Inheritance folder
        [Fact]
        public void HighPassSummingAggregator_Applies_Filter()
        {                
            var aggregator = new HighPassSummingAggregator();

            var result = aggregator.Aggregate(_measurements);

            Assert.Equal(105, result.X);
            Assert.Equal(15, result.Y);
        }

        readonly Measurement[] _measurements = {
            new Measurement { X = 5, Y = 10},
            new Measurement { X = 2, Y = 15},
            new Measurement { X = 100, Y = 5}                  
        };
    }
}