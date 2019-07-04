using System;
using System.Collections.Generic;
using System.Text;
using WeFirstCoreProject.Model;

namespace WeFirstCoreProject.Common.pagination
{
    public class PaginationBase
    {
        private int _pageSize = 20;
        public int PageIndex { get; set; } = 0;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value > MaxPageSize ? MaxPageSize : value;
        }

        public string OrderBy { get; set; } = nameof(EntityBase.Id);
        public int Count { get; set; }

        public int MaxPageSize { get; set; } = 1000;
        public int PageCount => Count / PageSize + (Count % PageSize > 0 ? 1 : 0);

        public PaginationBase Clone()
        {
            return new PaginationBase
            {
                PageIndex = PageIndex,
                PageSize = PageSize,
                OrderBy = OrderBy,
                Count = Count,
                MaxPageSize = MaxPageSize
            };
        }
    }
}
