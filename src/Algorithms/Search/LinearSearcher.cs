using System;
using System.Collections.Generic;

namespace Wingmann.Algorithms.Search
{
    /// <summary>
    /// Implements linear search algorithm.
    /// See on <see href="https://en.wikipedia.org/wiki/Linear_search">Wikipedia</see>.
    /// </summary>
    public class LinearSearcher : ISearcher
    {
        /// <inheritdoc cref="ISearcher.FindIndex{T}(IList{T}, T)" />
        public int FindIndex<T>(IList<T> data, T query) where T : IComparable<T>
        {
            if (data.Count == 0)
            {
                return -1;
            }
            
            for (var i = 0; i < data.Count; i++)
            {
                if (query.CompareTo(data[i]) is 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
