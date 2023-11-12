using System;
using System.Collections.Generic;

namespace Wingmann.Algorithms.Search
{
    /// <summary>
    /// Recursive binary search algorithm implementation.
    /// See on <see href="https://en.wikipedia.org/wiki/Binary_search_algorithm">Wikipedia</see>.
    /// </summary>
    public class RecursiveBinarySearcher : ISearcher
    {
        /// <inheritdoc cref="ISearcher.FindIndex{T}(IList{T}, T)" />
        public int FindIndex<T>(IList<T> data, T query) where T : IComparable<T>
            => FindIndex(data, query, 0, data.Count - 1);

        private static int FindIndex<T>(IList<T> data, T query, int left, int right)
            where T : IComparable<T>
        {
            if (left > right)
            {
                return -1;
            }

            var middleIndex = left + (right - left) / 2;
            var compared = query.CompareTo(data[middleIndex]);

            if (compared > 0)
            {
                return FindIndex(data, query, middleIndex + 1, right);
            }
            else if (compared < 0)
            {
                return FindIndex(data, query, left, middleIndex - 1);
            }
            else
            {
                return middleIndex;
            }
        }
    }
}
