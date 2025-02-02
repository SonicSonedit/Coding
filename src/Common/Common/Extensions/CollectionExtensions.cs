namespace Common.Extensions
{
    public static class CollectionExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> sender, Action<T> action)
        {
            foreach (var item in sender)
                action(item);
        }
    }
}
