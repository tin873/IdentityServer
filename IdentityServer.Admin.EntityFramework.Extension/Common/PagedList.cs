using System.Collections.Generic;

namespace IdentityServer.Admin.EntityFramework.Extension.Common
{
    public class PagedList<T> where T : class
    {
        public PagedList()
        {
            Data = new List<T>();
        }
        //data of page
        public List<T> Data { get; set; }
        //sum quantity of T
        public int TotalCount { get; set; }
        //sum quantity on the page
        public int PageSize { get; set; }
    }
}
