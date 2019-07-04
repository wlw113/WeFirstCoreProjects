using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeFirstCoreProject.Common.pagination
{
    public static class PagedListExtension
    {
        public static IPagedList<T> ToPageList<T>(this IQueryable<T> source, PaginationBase paginationBase) => new painatedList<T>(source, paginationBase);
    }
}
