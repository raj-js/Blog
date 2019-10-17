using System.Collections.Generic;

namespace Blog.Core.Sparrow.DTOs.Paging
{
    public class Paged<TDTO>
    {
        public IEnumerable<TDTO> List { get; set; }

        public long Total { get; set; }
    }
}
