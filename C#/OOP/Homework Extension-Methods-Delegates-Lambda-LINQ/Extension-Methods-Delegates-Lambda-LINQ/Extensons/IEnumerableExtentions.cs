namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public static class IEnumerableExtentions
    {
        public static T SumOfCollection<T>(this IEnumerable<T> collection) where T :struct
        {
            T result = (dynamic)0;
            foreach (T item in collection)
            {
                result += (dynamic)item;
            }
            return result;
        }
        public static T ProductOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)1;
            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }
            return result;
            
        }
        public static T MinOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Min();
        }
        public static T MaxOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Max();
        }
        public static T AvarageOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            return (dynamic)collection.SumOfCollection() / collection.Count();
        }   
        
    }
}
