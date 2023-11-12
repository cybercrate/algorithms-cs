using System;
using System.Collections.Generic;

namespace Wingmann.Algorithms.Search
{
    /// <summary>
    /// Binary search algorithm implementation.
    /// See on <see href="https://en.wikipedia.org/wiki/Binary_search_algorithm">Wikipedia</see>.
    /// </summary>
    public class BinarySearcher : ISearcher
    {
        /// <inheritdoc cref="ISearcher.FindIndex{T}(IList{T}, T)" />
        public int FindIndex<T>(IList<T> data, T query) where T : IComparable<T>
        {
            var left = 0;
            var right = data.Count - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;
                var compared = query.CompareTo(data[middle]);

                if (compared > 0)
                {
                    left = middle + 1;
                }
                else if (compared < 0)
                {
                    right = middle - 1;
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }
    }
}
