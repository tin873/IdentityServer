using System;
using System.Collections.Generic;
using System.Linq;

namespace IdentityServer.Admin.EntityFramework.Extension.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// the method is use to get query 
        /// </summary>
        /// <typeparam name="T">class?</typeparam>
        /// <param name="query">query</param>
        /// <param name="condition">condition</param>
        /// <param name="predicate">predicate</param>
        /// <returns>query</returns>
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> query, bool condition, Func<T, bool> predicate)
        {
            return condition 
                ? query.Where(predicate) 
                : query;
        }

        public static IEnumerable<T> TakeIf<T, Tkey>(this IEnumerable<T> query, Func<T, Tkey> orderBy, bool condition, int limit, bool orderByDescending = true)
        {
            //It necessary sort items before it
            query = orderByDescending ? query.OrderByDescending(orderBy) : query.OrderBy(orderBy);

            return condition 
                ? query.Take(limit) 
                : query;
        }
    }
}
