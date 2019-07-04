using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeFirstCoreProject.Common.pagination
{
    [Serializable]
    public class painatedList<T> : List<T>,IPagedList<T> 
    {
        public PaginationBase PaginationBase { get; }

        public painatedList(IQueryable<T> source,PaginationBase paginationBase)
        {
            PaginationBase = paginationBase;
            int total = source.Count();
            this.Count = total;
            this.TotalPages = (int)Math.Ceiling(total / (double)paginationBase.PageSize);
            this.PageSize = paginationBase.PageSize;
            this.PageIndex = paginationBase.PageIndex;
            this.AddRange(source.Skip(Math.Max(paginationBase.PageIndex - 1, 0) * paginationBase.PageSize).Take(paginationBase.PageSize).ToList());
        }
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public new int Count { get; private set; }
        public int TotalPages { get; private set; }
        public bool HasPrevious => PaginationBase.PageIndex > 0;
        public bool HasNext => PaginationBase.PageIndex < PaginationBase.PageCount - 1;
    }
}
