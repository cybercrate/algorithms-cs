using System;
using System.Collections.Generic;

namespace Wingmann.Algorithms.Search
{
    /// <summary>
    /// Common interface of most search algorithms.
    /// </summary>
    /// 
    public interface ISearcher
    {
        /// <summary>
        /// Finds the index of first occurrence of the target item.
        /// </summary>
        /// <typeparam name="T">Comparable type.</typeparam>
        /// <param name="data">Array where the element should be found.</param>
        /// <param name="query">Element which should be found.</param>
        /// <returns>Index of the first occurrence of the target element, or -1 if it is not found.</returns>
        int FindIndex<T>(IList<T> data, T query) where T : IComparable<T>;
    }
}
