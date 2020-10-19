using System.Collections.Generic;
using System.Linq;

namespace MhLabs.Extensions
{
    public static class CollectionExtension
    {
        public static bool IsNullOrEmpty<T>(this List<T> me) => !(me != null && me.Count() > 0);
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> me) => !me?.Any() ?? true;
        public static IEnumerable<IEnumerable<T>> GetChunks<T>(this IEnumerable<T> entities, int chunkSize) {
            return entities.Select((s, i) => new { Value = s, Index = i })
                .GroupBy(x => x.Index / chunkSize)
                .Select(grp => grp.Select(x => x.Value).ToList());
        }
    }
}
