using Wingmann.Algorithms.Search;

namespace Wingmann.Algorithms.Tests.Search;

internal static class TestCases
{
    public static (int[], int, int) FindIndex_QueryPresent_CorrectIndex(ISearcher searcher, int count)
    {
        var random = Randomizer.CreateRandomizer();
        var data = Enumerable.Range(0, count)
            .Select(_ => random.Next(0, 1000))
            .OrderBy(x => x)
            .ToArray();
            
        var selectedIndex = random.Next(0, count);
        var actual = searcher.FindIndex(data, data[selectedIndex]);

        return (data, selectedIndex, actual);
    }
    
    public static int FindIndex_QueryMissing_NegativeOneReturned(ISearcher searcher, int count, int query)
    {
        var random = Randomizer.CreateRandomizer();
        var data = Enumerable.Range(0, count)
            .Select(_ => random.Next(0, 1000))
            .Where(x => x != query)
            .OrderBy(x => x)
            .ToArray();

        return searcher.FindIndex(data, query);
    }
    
    public static int FindIndex_EmptyArray_NegativeOneReturned(ISearcher searcher, int query)
        => searcher.FindIndex(Array.Empty<int>(), query);
}