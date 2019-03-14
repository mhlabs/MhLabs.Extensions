using System.Collections.Generic;
using System.Linq;

namespace MhLabs.Extensions
{
    public static class CollectionExtension
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> me) => !me?.Any() ?? true;
    }
}
