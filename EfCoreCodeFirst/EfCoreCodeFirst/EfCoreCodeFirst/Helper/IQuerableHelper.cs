using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EfCoreCodeFirst.Helper
{
    public static class IQuerableHelper
    {


        public static void ToExpression<T>(this IQueryable<T> filterExpression)
        {


            //var resourceArg = Expression.Parameter(typeof(T));
            //var resourceComplexAttr = Expression.Property(resourceArg, filterExpression.Path);
            //var invokeFilterExpression = Expression.Invoke(filterDelegateExpression, resourceComplexAttr);
            //var predicate = Expression.Lambda<Func<T, bool>>(invokeFilterExpression, resourceArg);




        }





    }
}
