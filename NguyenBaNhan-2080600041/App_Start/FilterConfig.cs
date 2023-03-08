using System.Web;
using System.Web.Mvc;

namespace NguyenBaNhan_2080600041
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
