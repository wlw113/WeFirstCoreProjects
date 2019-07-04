using System;
using System.Collections.Generic;
using System.Text;

namespace WeFirstCoreProject.Common.pagination
{
    public interface IPagedList<T> : IList<T>
    {
        int PageIndex { get; }
        int PageSize { get; }
        new int Count { get; }
        int TotalPages { get; }
        bool HasPrevious { get; }
        bool HasNext { get; }
    }
}
