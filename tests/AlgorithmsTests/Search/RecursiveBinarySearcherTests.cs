using Wingmann.Algorithms.Search;

namespace Wingmann.Algorithms.Tests.Search
{
    internal class RecursiveBinarySearcherTests
    {
        private ISearcher _searcher;

        [SetUp]
        public void Setup()
        {
            _searcher = new RecursiveBinarySearcher();
        }

        [Test]
        public void CorrectIndex([Random(1, 1000, 100)] int count)
        {
            var actual = TestCases.FindIndex_QueryPresent_CorrectIndex(_searcher, count);
            Assert.That(actual.Item1[actual.Item2], Is.EqualTo(actual.Item1[actual.Item3]));
        }

        [Test]
        public void NegativeOneReturned(
            [Random(0, 1000, 10)] int count,
            [Random(-100, 1100, 10)] int missingQuery)
        {
            var actual = TestCases.FindIndex_QueryMissing_NegativeOneReturned(_searcher, count, missingQuery);
            Assert.That(actual, Is.EqualTo(-1));
        }

        [Test]
        public void NegativeOneReturned([Random(100)] int query)
        {
            var actual = TestCases.FindIndex_EmptyArray_NegativeOneReturned(_searcher, query);
            Assert.That(actual, Is.EqualTo(-1));
        }
    }
}
