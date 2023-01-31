namespace OTUS.Delegate.GetMax
{
    public static class IEnumerableExtensions
    {
        public static T? GetMax<T>(this IEnumerable<T> e, Func<T, float> getParameter) where T : class
        {
            return e.MaxBy(getParameter);
        }
    }
}
