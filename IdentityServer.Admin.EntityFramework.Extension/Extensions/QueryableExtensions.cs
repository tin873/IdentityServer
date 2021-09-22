using System;
using System.Linq;
using System.Linq.Expressions;

namespace IdentityServer.Admin.EntityFramework.Extension.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate)
        {
            return condition
                ? query.Where(predicate)
                : query;
        }

        public static IQueryable<T> TakeIf<T, Tkey>(this IQueryable<T> query, Expression<Func<T, Tkey>> orderBy, bool condition, int limit, bool orderByDescending = true)
        {
            query = orderByDescending ? query.OrderByDescending(orderBy) : query.OrderBy(orderBy);

            return condition
                ? query.Take(limit)
                : query;
        }

        public static IQueryable<T> PageBy<T, Tkey>(this IQueryable<T> query, Expression<Func<T, Tkey>> orderBy, int page, int pageSize, bool orderByDescending = true)
        {
            const int DefautlPageNumber = 1;
            if(query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }
            if(page < 0)
            {
                page = DefautlPageNumber;
            }

            query = orderByDescending ? query.OrderByDescending(orderBy) : query.OrderBy(orderBy);

            return query.Skip((page - 1) * pageSize).Take(pageSize);
        }    
    }
}
