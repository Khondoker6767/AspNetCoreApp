using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class PagenatedList<T>: List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPage { get; set; }
        public PagenatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPage = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }
        public bool previousPages
        {
            get
            {
                return (PageIndex > 1);
            }
        }
        public bool NextPage
        {
            get
            {
                return (PageIndex < TotalPage);
            }
        }
        public static async Task<PagenatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PagenatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}
