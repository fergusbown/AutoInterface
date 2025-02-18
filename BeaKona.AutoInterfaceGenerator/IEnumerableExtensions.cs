﻿namespace BeaKona.AutoInterfaceGenerator;

internal static class IEnumerableExtensions
{
    public static HashSet<T> ToHashSet<T>(this IEnumerable<T> @this)
    {
        if (@this == null)
        {
            return new HashSet<T>();
        }
        else
        {
            return new HashSet<T>(@this);
        }
    }

    public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
    {
        HashSet<TKey> seenKeys = new();

        foreach (TSource element in source)
        {
            if (seenKeys.Add(keySelector(element)))
            {
                yield return element;
            }
        }
    }
}
