using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Returns the number of items in the collection
        /// </summary>
        public static int Number<T>(this IEnumerable<T> collection)
        {
            int count = 0;

            foreach (var key in collection)
            {
                count++;
            }

            return count;
        }

        /// <summary>
        /// Performs the given action on each item of the collection
        /// </summary>
        public static int ForEachItem<T>(this IEnumerable<T> collection, Action<T> action)
        {
            int count = 0;
            foreach (T key in collection)
            {
                action(key);
                count++;
            }
            return count;
        }

        /// <summary>
        /// Returns a collection of items that contain the given string
        /// </summary>
        public static IEnumerable<string> Has(this IEnumerable<string> collection, string thing)
        {
            foreach (string item in collection)
            {
                if (item.Contains(thing))
                {
                    yield return item;
                }
            }
        }

        /// <summary>
        /// Returns the last item in the collection
        /// </summary>
        public static T Ultimate<T>(this IEnumerable<T> collection)
        {
            return collection.ElementAt(collection.Count() - 1);
        }

        /// <summary>
        /// Returns the second to last item in the collection
        /// </summary>
        public static T Penultimate<T>(this IEnumerable<T> collection)
        {
            return collection.ElementAt(collection.Count() - 2);
        }

        /// <summary>
        /// Returns the third to last item in the collection
        /// </summary>
        public static T Antepenultimate<T>(this IEnumerable<T> collection)
        {
            return collection.ElementAt(collection.Count() - 3);
        }

    }
}
