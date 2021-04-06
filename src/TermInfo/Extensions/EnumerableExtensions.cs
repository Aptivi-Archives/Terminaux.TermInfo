#if !NET5_0
using System.Collections.Generic;
using System.Linq;

namespace TermInfo
{
    internal static class EnumerableExtensions
    {
        public static IEnumerable<(TFirst First, TSecond Second)> Zip<TFirst, TSecond>(
            this IEnumerable<TFirst> source, IEnumerable<TSecond> first)
        {
            return source.Zip(first, (first, second) => (first, second));
        }
    }
}
#endif