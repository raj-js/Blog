using System.Collections.Generic;

namespace Blog.Core.Sparrow.DTOs.Paging
{
    public class PagingHelper
    {
        public static Paged<TDTO> From<TDTO>(List<TDTO> dtos, long total)
        {
            return new Paged<TDTO>() { List = dtos, Total = total };
        }
    }
}
